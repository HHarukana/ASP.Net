using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


public class PersonV2 : Person
{

    public const string connstring = @"Server=sql.neit.edu\StudentSQLServer,4500;Database=SE245_IShippee;User Id=SE245_IShippee;Password=001317108;";
    public Int32 Person_ID = 0;


    public string AddARecord()
     {
        string strResult = "";

        string strSQL = "INSERT INTO Person (FirstName, MiddleName, LastName, Street, City, State, Zip, Number, EMail) VALUES (@PersonFirst, @PersonMiddle, @PersonLast, @PersonStreet, @PersonCity, @PersonState, @PersonZip, @PersonNum, @PersonMail)";

        SqlConnection Conn = new SqlConnection();

        Conn.ConnectionString = @"Server=sql.neit.edu\StudentSQLServer,4500;Database=SE245_IShippee;User Id=SE245_IShippee;Password=001317108;";

        

        SqlCommand comm = new SqlCommand();
        comm.CommandText = strSQL;

        comm.Connection = Conn;

        
        comm.Parameters.AddWithValue("@PersonFirst",  PersonFirst);
        comm.Parameters.AddWithValue("@PersonMiddle", PersonMiddle);
        comm.Parameters.AddWithValue("@PersonLast", PersonLast);
        comm.Parameters.AddWithValue("@PersonStreet", PersonStreet);
        comm.Parameters.AddWithValue("@PersonCity", PersonCity);
        comm.Parameters.AddWithValue("@PersonState", PersonState);
        comm.Parameters.AddWithValue("@PersonZip", PersonZip);
        comm.Parameters.AddWithValue("@PersonNum", PersonNum);
        comm.Parameters.AddWithValue("@PersonMail", PersonMail);


        try
        {
            Conn.Open();

            int intRecs = comm.ExecuteNonQuery();
            strResult = intRecs.ToString() + "Records Added";
            Conn.Close();

        }

        catch (Exception err)

        {
            strResult = "ERROR: " + err.Message;
        }

        finally
        {

        }

        return strResult;
    }

    public DataSet SearchAPerson(String FirstName, String LastName)
    {

        DataSet ds = new DataSet();

        SqlCommand comm = new SqlCommand();

        String strSQL = "SELECT PersonID, FirstName, LastName FROM Person WHERE 0=0";

        if (FirstName.Length > 0)
        {
            strSQL += " AND FirstName LIKE @PersonFirst";
            comm.Parameters.AddWithValue("@PersonFirst", "%" + FirstName + "%");

        }

        if (LastName.Length > 0)
        {
            strSQL += " AND LastName LIKE @PersonLast";
            comm.Parameters.AddWithValue("@PersonLast", "%" + LastName + "%");

        }

        SqlConnection conn = new SqlConnection();

        string strConn = @connstring;
        conn.ConnectionString = strConn;

        comm.Connection = conn;

        comm.CommandText = strSQL;

        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = comm;


        conn.Open();
        da.Fill(ds, "Person");

        conn.Close();

        return ds;
    }


    public SqlDataReader FindAPerson(int intPersonID)
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand comm = new SqlCommand();

        string strConn = @connstring;

        string sqlString = "Select PersonID, FirstName, MiddleName, LastName, Street, City, State, Zip, Number, EMail FROM Person WHERE PersonID = @PersonID;";

        conn.ConnectionString = strConn;

        comm.Connection = conn;
        comm.CommandText = sqlString;
        comm.Parameters.AddWithValue("@PersonID", intPersonID);

        conn.Open();

        return comm.ExecuteReader();
    }

    public Int32 DeleteAPerson(int intPersonID)
    {
        Int32 intRecords = 0;

        SqlConnection conn = new SqlConnection();
        SqlCommand comm = new SqlCommand();

        
        string strConn = @connstring;

        string sqlString = "DELETE FROM Person WHERE PersonID = @Person_ID;";

        conn.ConnectionString = strConn;

        comm.Connection = conn;
        comm.CommandText = sqlString;
        comm.Parameters.AddWithValue("@PersonID", intPersonID);

        conn.Open();

        intRecords = comm.ExecuteNonQuery();

        conn.Close();

        return intRecords;


    }

    public Int32 UpdateAPerson(int intPersonID)
    {
        Int32 intRecords = 0;

        string strSQL = "UPDATE Person SET FirstName = @PersonFirst, MiddleName = @PersonMiddle, LastName = @PersonLast, Street = @PersonStreet, City = @PersonCity, State = @PersonState, Zip = @PersonZip, Number = @PersonNumber, EMail = @PersonMail WHERE PersonID = @Person_ID;";

        SqlConnection conn = new SqlConnection();

        string strConn = @connstring;
        conn.ConnectionString = strConn;

        SqlCommand comm = new SqlCommand();
        comm.CommandText = strSQL;  
        comm.Connection = conn;

        comm.Parameters.AddWithValue("@PersonFirst", PersonFirst);
        comm.Parameters.AddWithValue("@PersonMiddle", PersonMiddle);
        comm.Parameters.AddWithValue("@PersonLast", PersonLast);
        comm.Parameters.AddWithValue("@PersonStreet", PersonStreet);
        comm.Parameters.AddWithValue("@PersonCity", PersonCity);
        comm.Parameters.AddWithValue("@PersonState", PersonState);
        comm.Parameters.AddWithValue("@PersonZip", PersonZip);
        comm.Parameters.AddWithValue("@PersonNum", PersonNum);
        comm.Parameters.AddWithValue("@PersonMail", PersonMail);
        comm.Parameters.AddWithValue("@Person_ID", intPersonID);

        try
        {
            conn.Open();

            intRecords = comm.ExecuteNonQuery();

        }

        catch(Exception err)
        {

        }

        finally
        {
            conn.Close();
        }

        return intRecords;
    }

}
