using Mvc_ADOCRUD_Demo.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Mvc_ADOCRUD_Demo.Models.DAL
{
    public class PuppiesDAO
    {
        SqlConnection con = null;
        SqlCommand cmd = null;

        public PuppiesDAO()
        {
            con = new SqlConnection("Server=.;Database=EurofinDB;Integrated Security=true;");
            cmd = new SqlCommand() { Connection=con };
        }

        public List<Puppies> GetAllPuppiess()
        {
            cmd.CommandText = "Select * From Puppies";
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Puppies> Puppiess = new List<Puppies>();
            while(reader.Read())
            {
                Puppiess.Add(new Puppies()
                {
                    ID=Convert.ToInt32(reader["ID"]),
                    Name=reader["Name"].ToString(),
                    Skill=reader["Skill"].ToString()
                });
            }
            reader.Close();
            con.Close();
            cmd.CommandText = string.Empty;
            return Puppiess;
        }

        public Puppies GetPuppiesByPuppiesNo(int PuppiesNo)
        {
            cmd.CommandText = "Select * From Puppies Where ID=@PuppiesNo";
            cmd.Parameters.Add(new SqlParameter("@PuppiesNo",PuppiesNo));
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Puppies d = null;
            //reader.Read();
           if(reader.Read())
            {
                d= new Puppies()
                {
                     ID=Convert.ToInt32(reader["ID"]),
                    Name=reader["Name"].ToString(),
                    Skill=reader["Skill"].ToString()
                };
            }
            reader.Close();
            con.Close();
            cmd.Parameters.Clear();
            cmd.CommandText = string.Empty;
            return d;
        }

        public void SavePuppies(Puppies d)
        {
            cmd.CommandText = "Insert Puppies Values(@Name, @SkillName)";
           // cmd.Parameters.Add(new SqlParameter("@PuppiesNo", d.ID));
            cmd.Parameters.Add(new SqlParameter("@Name", d.Name));
            cmd.Parameters.Add(new SqlParameter("@SkillName", d.Skill));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Parameters.Clear();
            cmd.CommandText = string.Empty;
        }

        public void UpdatePuppies(Puppies d)
        {
            cmd.CommandText = "Update Puppies Set DName = @DName, Location = @Location Where PuppiesNo=@PuppiesNo";
             cmd.Parameters.Add(new SqlParameter("@PuppiesNo", d.ID));
            cmd.Parameters.Add(new SqlParameter("@DName", d.Name));
            cmd.Parameters.Add(new SqlParameter("@Location", d.Skill));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Parameters.Clear();
            cmd.CommandText = string.Empty;
        }

        public void DeletePuppies(int PuppiesNo)
        {
            cmd.CommandText = "Delete Puppies Where PuppiesNo=@PuppiesNo";
            cmd.Parameters.Add(new SqlParameter("@PuppiesNo", PuppiesNo));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Parameters.Clear();
            cmd.CommandText = string.Empty;
        }
    }
    }
