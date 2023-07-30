using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace SureshKThakur.Models
{
    public class EmployeeDBContext
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public List<Employee> GetEmployee()
        {
            List<Employee> EmpList = new List<Employee>();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("GetEmployeeList",con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Employee emp = new Employee();
                emp.EmployeeId = Convert.ToInt32(dr.GetValue(0).ToString());
                emp.Name = dr.GetValue(1).ToString();
                emp.Address = dr.GetValue(2).ToString();
                emp.Salary = Convert.ToInt32(dr.GetValue(3).ToString());
                EmpList.Add(emp);

            }

            con.Close();

            return EmpList;
        }

        public bool SaveEmp(String Name, String Address, String Salary)
        {
            bool result1 = false;
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    using (SqlCommand cmd = new SqlCommand("SaveEmp", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = Name;
                        cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = Address;
                        cmd.Parameters.Add("@Salary", SqlDbType.Int).Value =Convert.ToInt32(Salary) ;

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                result1 = true;
            }
            catch(Exception e)
            {
               
            }
          
            return result1;
        }
        public bool SaveStudentRegistration(Student student)
        {
            bool result1 = false;
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    using (SqlCommand cmd = new SqlCommand("SaveStudentRegistration", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = student.FirstName;
                        cmd.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = student.MiddleName;
                        cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = student.LastName;
                        cmd.Parameters.Add("@DOB", SqlDbType.VarChar).Value = student.DOB;
                        cmd.Parameters.Add("@Gender", SqlDbType.VarChar).Value = student.Gender;
                        cmd.Parameters.Add("@StudentClass", SqlDbType.VarChar).Value = student.StudentClass;
                        cmd.Parameters.Add("@AdmissionDate", SqlDbType.VarChar).Value = student.AdmissionDate;
                        cmd.Parameters.Add("@StudentEmailId", SqlDbType.VarChar).Value = student.StudentEmailId;
                        cmd.Parameters.Add("@MotherName", SqlDbType.VarChar).Value = student.MotherName;
                        cmd.Parameters.Add("@FatherName", SqlDbType.VarChar).Value = student.FatherName;
                        cmd.Parameters.Add("@ParentsPhoneNo", SqlDbType.VarChar).Value = student.ParentsPhoneNo;
                        cmd.Parameters.Add("@Address1", SqlDbType.VarChar).Value = student.Address1;
                        cmd.Parameters.Add("@Address2", SqlDbType.VarChar).Value = student.Address2;
                        cmd.Parameters.Add("@State", SqlDbType.VarChar).Value = student.State;
                        cmd.Parameters.Add("@District", SqlDbType.VarChar).Value = student.District;
                        cmd.Parameters.Add("@PolicStation", SqlDbType.VarChar).Value = student.PolicStation;
                        cmd.Parameters.Add("@PostOffice", SqlDbType.VarChar).Value = student.PostOffice;

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                result1 = true;
            }
            catch (Exception e)
            {

            }

            return result1;
        }

        public List<StudentClass> GetStudentClass()
        {
            List<StudentClass> StdClassList = new List<StudentClass>();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("GetClassName", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                StudentClass StdClass = new StudentClass();
                StdClass.ClassId = Convert.ToInt32(dr.GetValue(0).ToString());
                StdClass.ClassName = dr.GetValue(1).ToString();
                StdClassList.Add(StdClass);

            }

            con.Close();

            return StdClassList;
        }
        public List<Common> GetStateList()
        {
            List<Common> comObjList = new List<Common>();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("GetStateList", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Common comObj = new Common();
                comObj.ItemId = Convert.ToInt32(dr.GetValue(0).ToString());
                comObj.ItemName = dr.GetValue(1).ToString();
                comObjList.Add(comObj);
            }
            con.Close();
            return comObjList;
        }
        public List<Common> GetDistrictByState(int StateId)
        {
            List<Common> comObjList = new List<Common>();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("GetDistrictByStateId", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@StateId", StateId));
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Common comObj = new Common();
                comObj.ItemId = Convert.ToInt32(dr.GetValue(0).ToString());
                comObj.ItemName = dr.GetValue(1).ToString();
                comObjList.Add(comObj);
            }
            con.Close();
            return comObjList;
        }

        

        
    }
}