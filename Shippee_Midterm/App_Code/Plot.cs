using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


public class Plot
{
    private string plotID;
    private string currDate;
    private string cemetary;
    private string firstName;
    private string middleName;
    private string lastName;
    private string title;
    private string DOB;
    private string DOD;
    private bool vet;
    private string branch;
    private string stone;
    private string note;

    protected string feedback { get; set; }



    public string PlotID
    {

        set
        {
            if (!Validator.gotBadWords(value))
            {
                plotID = value;
            }

            else
            {

                plotID = string.Empty;

            }
        }

        get { return plotID; }

    }


    public string CurrDate
    {

        set
        {
            if (!Validator.gotBadWords(value))
            {
                currDate = value;
            }

            else
            {

                currDate = string.Empty;

            }
        }

        get { return currDate; }

    }


    public string Cemetary
    {

        set
        {
            if (!Validator.gotBadWords(value))
            {
                cemetary = value;
            }

            else
            {

                cemetary = string.Empty;

            }
        }

        get { return cemetary; }

    }


    public string FirstName
    {

        set
        {
            if (!Validator.gotBadWords(value))
            {
                firstName = value;
            }

            else
            {

                firstName = string.Empty;

            }
        }

        get { return firstName; }

    }


    public string MiddleName
    {

        set
        {
            if (!Validator.gotBadWords(value))
            {
                middleName = value;
            }

            else
            {

                middleName = string.Empty;

            }
        }

        get { return middleName; }

    }


    public string LastName
    {

        set
        {
            if (!Validator.gotBadWords(value))
            {
                lastName = value;
            }

            else
            {

                lastName = string.Empty;

            }
        }

        get { return lastName; }

    }


    public string Title
    {

        set
        {
            if (!Validator.gotBadWords(value))
            {
                title = value;
            }

            else
            {

                title = string.Empty;

            }
        }

        get { return title; }

    }


    public string DateOB
    {

        set
        {
            if (!Validator.gotBadWords(value))
            {
                DOB = value;
            }

            else
            {

                DOB = string.Empty;

            }
        }

        get { return DOB; }

    }


    public string DateOD
    {

        set
        {
            if (!Validator.gotBadWords(value))
            {
                DOD = value;
            }

            else
            {

                DOD = string.Empty;

            }
        }

        get { return DOD; }

    }

    public Boolean Vet
    {

        get { return vet; }
        set { vet = value; }

    }

    public string Branch
    {

        set
        {
            if (!Validator.gotBadWords(value))
            {
                branch = value;
            }

            else
            {

                branch = string.Empty;

            }
        }

        get { return branch; }

    }

    public string Stone
    {

        set
        {
            if (!Validator.gotBadWords(value))
            {
                stone = value;
            }

            else
            {

                stone = string.Empty;

            }
        }

        get { return stone; }

    }

    public string Note
    {

        set
        {
            if (!Validator.gotBadWords(value))
            {
                note = value;
            }

            else
            {

                note = string.Empty;

            }
        }

        get { return note; }

    }

    public Plot(string plotID, string currDate, string cemetary, string firstName, string middleName, string lastName, string title, string DOB, string DOD, bool vet, string branch, string stone, string note)
    {
        this.PlotID = plotID;
        this.CurrDate = currDate;
        this.Cemetary = cemetary;
        this.FirstName = firstName;
        this.MiddleName = middleName;
        this.LastName = lastName;
        this.Title = title;
        this.DateOB = DOB;
        this.DateOD = DOD;
        this.Vet = vet;
        this.Branch = branch;
        this.Stone = stone;
        this.Note = note;

    }

    public string Feedback
    {
        get { return feedback; }
    }

    public Plot()
    {

        PlotID = string.Empty;
        CurrDate = string.Empty;
        Cemetary = string.Empty;
        FirstName = string.Empty;
        MiddleName = string.Empty;
        LastName = string.Empty;
        Title = string.Empty;
        DateOB = string.Empty;
        DateOD = string.Empty;
        Vet = false;
        Branch = string.Empty;
        Stone = string.Empty;
        Note = string.Empty;
        feedback = string.Empty;

    }

    public const string connstring = @"Server=sql.neit.edu\StudentSQLServer,4500;Database=SE245_IShippee;User Id=SE245_IShippee;Password=001317108;";
    public Int32 Plot_ID = 0;


    public string AddAPlot()
    {
        string strResult = "";

        string strSQL = "INSERT INTO plot (currDate, cemetary, firstName, middleName, lastName, title, DOB, DOD, vet, branch, stone, note) VALUES (@CurrDate, @Cemetary, @FirstName, @MiddleName, @LastName, @Title, @DateOB, @DateOD, @Vet, @Branch, @Stone, @Note)";

        SqlConnection Conn = new SqlConnection();

        Conn.ConnectionString = @"Server=sql.neit.edu\StudentSQLServer,4500;Database=SE245_IShippee;User Id=SE245_IShippee;Password=001317108;";



        SqlCommand comm = new SqlCommand();
        comm.CommandText = strSQL;

        comm.Connection = Conn;


        comm.Parameters.AddWithValue("@CurrDate", currDate);
        comm.Parameters.AddWithValue("@Cemetary", cemetary);
        comm.Parameters.AddWithValue("@Firstname", firstName);
        comm.Parameters.AddWithValue("@MiddleName", middleName);
        comm.Parameters.AddWithValue("@LastName", lastName);
        comm.Parameters.AddWithValue("@Title", title);
        comm.Parameters.AddWithValue("@DateOB", DOB);
        comm.Parameters.AddWithValue("@DateOD", DOD);
        comm.Parameters.AddWithValue("@Vet", vet);
        comm.Parameters.AddWithValue("@Branch", branch);
        comm.Parameters.AddWithValue("@Stone", stone);
        comm.Parameters.AddWithValue("@Note", note);


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

    public DataSet SearchAPlot(String Cemetary, String LastName)
    {

        DataSet ds = new DataSet();

        SqlCommand comm = new SqlCommand();

        String strSQL = "SELECT plotID, cemetary, lastName FROM plot WHERE ";

        //if (Cemetary.Length > 0)
        //{
        //    strSQL += " cemetary LIKE ISNULL(@Cemetary, cemetary)";
        //    comm.Parameters.AddWithValue("@Cemetary", "%" + cemetary + "%");

        //}

        //if (LastName.Length > 0)
        //{
        //    strSQL += " lastName LIKE ISNULL(@LastName, lastName)";
        //    comm.Parameters.AddWithValue("@LastName", "%" + lastName + "%");

        //}


        strSQL += " cemetary LIKE ISNULL(@Cemetary, cemetary)";
        comm.Parameters.AddWithValue("@Cemetary", "%" + Cemetary + "%");

        strSQL += " AND lastName LIKE ISNULL(@LastName, lastName)";
        comm.Parameters.AddWithValue("@LastName", "%" + LastName + "%");





        SqlConnection conn = new SqlConnection();

        string strConn = @connstring;
        conn.ConnectionString = strConn;

        comm.Connection = conn;

        comm.CommandText = strSQL;

        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = comm;


        conn.Open();
        da.Fill(ds, "Plot");

        conn.Close();

        return ds;
    }


    public SqlDataReader FindAPlot(int intPlotID)
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand comm = new SqlCommand();

        string strConn = @connstring;

        string sqlString = "Select plotID, currDate, cemetary, firstName, middlename, lastName, title, DOB, DOD, vet, branch, stone, note FROM plot WHERE plotID =  @PlotID;";

        conn.ConnectionString = strConn;

        comm.Connection = conn;
        comm.CommandText = sqlString;
        comm.Parameters.AddWithValue("@PlotID", intPlotID);

        conn.Open();

        return comm.ExecuteReader();
    }

    public Int32 DeleteAPlot(int intPlotID)
    {
        Int32 intRecords = 0;

        SqlConnection conn = new SqlConnection();
        SqlCommand comm = new SqlCommand();

        try
        {
            string strConn = @connstring;

            string sqlString = "DELETE FROM plot WHERE plotID = " + @Plot_ID;

            conn.ConnectionString = strConn;

            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@PlotID", intPlotID);

            conn.Open();

            intRecords = comm.ExecuteNonQuery();

            conn.Close();
        }

        catch (Exception ex)
        {
            throw new Exception(ex.Message);

        }

        return intRecords;




    }



    public Int32 UpdateAPlot(int intPlotID)
    {
        Int32 intRecords = 0;

        string strSQL = "UPDATE plot SET currDate = @CurrDate, cemetary = @Cemetary, firstName = @FirstName, middleName = @MiddleName, lastName = @LastName, title = @Title, DOB = @DateOB, DOD = @DateOD, vet = @Vet, branch = @Branch, stone = @Stone, note = @Note WHERE plotID = @Plot_ID;";

        SqlConnection conn = new SqlConnection();

        string strConn = @connstring;
        conn.ConnectionString = strConn;

        SqlCommand comm = new SqlCommand();
        comm.CommandText = strSQL;
        comm.Connection = conn;

        comm.Parameters.AddWithValue("@CurrDate", currDate);
        comm.Parameters.AddWithValue("@Cemetary", cemetary);
        comm.Parameters.AddWithValue("@Firstname", firstName);
        comm.Parameters.AddWithValue("@MiddleName", middleName);
        comm.Parameters.AddWithValue("@LastName", lastName);
        comm.Parameters.AddWithValue("@Title", title);
        comm.Parameters.AddWithValue("@DateOB", DOB);
        comm.Parameters.AddWithValue("@DateOD", DOD);
        comm.Parameters.AddWithValue("@Vet", vet);
        comm.Parameters.AddWithValue("@Branch", branch);
        comm.Parameters.AddWithValue("@Stone", stone);
        comm.Parameters.AddWithValue("@Note", note);
        comm.Parameters.AddWithValue("@Plot_ID", intPlotID);

        try
        {
            conn.Open();

            intRecords = comm.ExecuteNonQuery();

        }

        catch (Exception err)
        {
            throw new Exception(err.Message);
        }

        finally
        {
            conn.Close();
        }

        return intRecords;
    }
}