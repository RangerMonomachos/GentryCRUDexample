using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GentryCRUDexample
{
    class DBProcs
    {
        //this is the procs for putting new stuff into the people database.
        public static void insertRow(RowData rd)
        {
            insertCustomers(rd);
            insertCustomersAddress(rd);
            getCurrentCustId(rd);
            getCurrentAddId(rd);
            updateAddressForAdd(rd);
        }
        private static void insertCustomers(RowData rd)
        {
            using (SqlConnection conn = new SqlConnection(DataBase.ReturnConnection()))
            {
                SqlCommand cmd = new SqlCommand("InsertCustomers", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Title", rd.title);
                cmd.Parameters.AddWithValue("@firstName", rd.firstName);
                cmd.Parameters.AddWithValue("@lastName", rd.lastName);
                cmd.Parameters.AddWithValue("@middleName", rd.middleName);
                cmd.Parameters.AddWithValue("@suffix", rd.suffex);
                cmd.Parameters.AddWithValue("@companyName", rd.companyName);
                cmd.Parameters.AddWithValue("@salesPerson", rd.salesPerson);
                cmd.Parameters.AddWithValue("@emailAddress", rd.email);
                cmd.Parameters.AddWithValue("@phone", rd.phone);
                cmd.Parameters.AddWithValue("@PasswordHash", rd.passhash);
                cmd.Parameters.AddWithValue("@PasswordSalt", rd.passSalt);
                cmd.Parameters.AddWithValue("@modifydate", rd.modDate);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        private static void insertCustomersAddress(RowData rd)
        {
            using (SqlConnection conn = new SqlConnection(DataBase.ReturnConnection()))
            {
                SqlCommand cmd = new SqlCommand("InsertAddress", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@addressLine1", rd.addLine1);
                cmd.Parameters.AddWithValue("@addressLine2", rd.addLine2);
                cmd.Parameters.AddWithValue("@city", rd.city);
                cmd.Parameters.AddWithValue("@stateProvince", rd.stateProv);
                cmd.Parameters.AddWithValue("@countryRegion", rd.country);
                cmd.Parameters.AddWithValue("@postalCode", rd.postalc);
                cmd.Parameters.AddWithValue("@modifiedDate", rd.modDate);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        private static void getCurrentCustId(RowData rd)
        {
            using (SqlConnection conn = new SqlConnection(DataBase.ReturnConnection()))
            {

                SqlCommand cmd = new SqlCommand("getlastCustID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                rd.custID = dr.GetInt32(0);

            }
        }
        private static void getCurrentAddId(RowData rd)
        {

            using (SqlConnection conn = new SqlConnection(DataBase.ReturnConnection()))
            {

                SqlCommand cmd = new SqlCommand("getlastaddID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                rd.addID = dr.GetInt32(0);

            }
        }

        private static void updateAddressForAdd(RowData rd)
        {
            using (SqlConnection conn = new SqlConnection(DataBase.ReturnConnection()))
            {
                SqlCommand cmd = new SqlCommand("InsertCustomerAddress", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@custID", rd.custID);
                cmd.Parameters.AddWithValue("@addID", rd.addID);
                cmd.Parameters.AddWithValue("@addressType", rd.addType);
                cmd.Parameters.AddWithValue("@modifiedDate", rd.modDate);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //update is handled here
        public static void updateRow(RowData rd)
        {
            updateCustomers(rd);
            updateCustomersAddress(rd);
            updateAddress(rd);
        }
        private static void updateCustomers(RowData rd)
        {
            using (SqlConnection conn = new SqlConnection(DataBase.ReturnConnection()))
            {
                SqlCommand cmd = new SqlCommand("UpdateCustomers", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@custID", rd.custID);
                cmd.Parameters.AddWithValue("@Title", rd.title);
                cmd.Parameters.AddWithValue("@firstName", rd.firstName);
                cmd.Parameters.AddWithValue("@lastName", rd.lastName);
                cmd.Parameters.AddWithValue("@middleName", rd.middleName);
                cmd.Parameters.AddWithValue("@suffix", rd.suffex);
                cmd.Parameters.AddWithValue("@companyName", rd.companyName);
                cmd.Parameters.AddWithValue("@salesPerson", rd.salesPerson);
                cmd.Parameters.AddWithValue("@emailAddress", rd.email);
                cmd.Parameters.AddWithValue("@phone", rd.phone);
                cmd.Parameters.AddWithValue("@PasswordHash", rd.passhash);
                cmd.Parameters.AddWithValue("@PasswordSalt", rd.passSalt);
                cmd.Parameters.AddWithValue("@modifydate", rd.modDate);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        private static void updateCustomersAddress(RowData rd)
        {
            using (SqlConnection conn = new SqlConnection(DataBase.ReturnConnection()))
            {
                SqlCommand cmd = new SqlCommand("updateCustomerAddress", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@customerID", rd.custID);
                cmd.Parameters.AddWithValue("@addressID", rd.addID);
                cmd.Parameters.AddWithValue("@addressType", rd.addType);
                cmd.Parameters.AddWithValue("@modifiedDate", rd.modDate);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        private static void updateAddress(RowData rd)
        {
            using (SqlConnection conn = new SqlConnection(DataBase.ReturnConnection()))
            {
                SqlCommand cmd = new SqlCommand("updateAddress", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@addressID", rd.addID);
                cmd.Parameters.AddWithValue("@addressLine1", rd.addLine1);
                cmd.Parameters.AddWithValue("@addressLine2", rd.addLine2);
                cmd.Parameters.AddWithValue("@city", rd.city);
                cmd.Parameters.AddWithValue("@stateProvince", rd.stateProv);
                cmd.Parameters.AddWithValue("@countryRegion", rd.country);
                cmd.Parameters.AddWithValue("@postalCode", rd.postalc);
                cmd.Parameters.AddWithValue("@modifiedDate", rd.modDate);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        //the delete methods.
        public static void deleteTheRow(DataGridView row)
        {
            using (SqlConnection conn = new SqlConnection(DataBase.ReturnConnection()))
            {
                var custID = row.SelectedRows[0].Cells[0].Value;
                var addID = row.SelectedRows[0].Cells[13].Value;
                SqlCommand cmd = new SqlCommand("DeleteCustomers", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@custID", custID);
                cmd.Parameters.AddWithValue("@addressID", addID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
