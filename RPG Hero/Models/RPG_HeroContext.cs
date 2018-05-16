using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace RPG_Hero.Models
{
    public class RPG_HeroContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public string ConnectionString { get; set; }


        public RPG_HeroContext()
        {
        }

        public void EditById(Hero hero)
        {
            string ConnectionString = "Server =localhost ; Database = RPGGame; Trusted_Connection = True";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update hero SET health = @health, Lvl = @Lvl, currentExp = @currentExp, AttackPower = @AttackPower where id = @id", conn);
                cmd.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@health",
                    DbType = DbType.Int32,
                    Value = hero.Health,
                });
                cmd.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@Lvl",
                    DbType = DbType.Int32,
                    Value = hero.Lvl,
                });
                cmd.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@currentExp",
                    DbType = DbType.Int32,
                    Value = hero.CurrentExp,
                });
                cmd.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@AttackPower",
                    DbType = DbType.Int32,
                    Value = hero.AttackPower,
                });
                cmd.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@Id",
                    DbType = DbType.Int32,
                    Value = hero.Id,
                });
                cmd.ExecuteNonQuery();
            }

        }

        public List<Hero> getAllHeroes()
        {
            string ConnectionString = "Server =localhost ; Database = RPGGame; Trusted_Connection = True";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                List<Hero> heroes = new List<Hero>();
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from hero",conn);
                SqlDataReader dataReader = cmd.ExecuteReader();

                while(dataReader.Read())
                {
                    Hero hero = new Hero();
                    hero.Id = (int)dataReader["Id"];
                    hero.AttackPower = (int)dataReader["AttackPower"];
                    hero.Health = (int)dataReader["Health"];
                    hero.Lvl = (int)dataReader["Lvl"];
                    hero.CurrentExp = (int)dataReader["CurrentExp"];

                    heroes.Add(hero);
                }
                return heroes;
            }
                
        }

        public Hero GetHeroById(int id)
        {
            string ConnectionString = "Server =localhost ; Database = RPGGame; Trusted_Connection = True";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from hero where id = @id", conn);
                cmd.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@id",
                    DbType = DbType.Int32,
                    Value = id,
                });
                SqlDataReader reader = cmd.ExecuteReader();
                Hero hero = new Hero();

                while (reader.Read())
                {
                    hero.AttackPower = (int)reader["AttackPower"];
                    hero.CurrentExp = (int)reader["CurrentExp"];
                    hero.Health = (int)reader["Health"];
                    hero.Lvl = (int)reader["Lvl"];
                    hero.Id = (int)reader["Id"];
                }
                return hero;
            }
        }

        public void DeleteHero(int id)
        {
            string ConnectionString = "Server =localhost ; Database = RPGGame; Trusted_Connection = True";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from hero where id = @id", conn);
                cmd.Parameters.Add(new SqlParameter {
                    ParameterName = "@id",
                    DbType = DbType.Int32,
                    Value = id,
                });
                cmd.ExecuteNonQuery();
            }
        }
            public void Create(Hero hero)
        {
            string ConnectionString = "Server =localhost ; Database = RPGGame; Trusted_Connection = True";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into hero values (@Health,@Lvl,@AttackPower,@currentExp)", conn);
                cmd.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@Health",
                    DbType = DbType.Int32,
                    Value = hero.Health,
                });
                cmd.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@Lvl",
                    DbType = DbType.Int32,
                    Value = hero.Lvl,
                });
                cmd.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@AttackPower",
                    DbType = DbType.Int32,
                    Value = hero.AttackPower,
                });
                cmd.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@CurrentExp",
                    DbType = DbType.Int32,
                    Value = hero.CurrentExp,
                });
                cmd.ExecuteNonQuery();
            }
        }
    }
}
