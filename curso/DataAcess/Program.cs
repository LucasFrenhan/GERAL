﻿using System;
using Microsoft.Data.SqlClient;

namespace DataAcess
{
    class program
    {
        static void Main(string[] args)
        {
            const string connectionString = "Server=localhost,1433;Database=balta;User ID=sa;Password=1q2w3e4r@#$";

            using (var connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("Conectado");
            }
        }
    }
}