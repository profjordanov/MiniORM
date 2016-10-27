using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniORMLive.Entities
{
    using System.Data;
    using MiniORMLive.Attributes;

    [Entity(TableName = "Users")]
    class User
    {
        [Id]
        private int id;

        [Column(ColumnName = "Username")]
        private string username;

        [Column(ColumnName = "Pass")]
        private string password;

        [Column(ColumnName = "Age")]
        private int age;

        [Column(ColumnName = "RegistrationDate")]
        private DateTime registrationDate;

        [Column(ColumnName = "LastLoginTime")]
        private DateTime lastLoginTime;

        [Column(ColumnName = "IsActive")]
        private bool isActive;

        public User(string username, string password, int age, DateTime registrationDate, DateTime lastLoginTime, bool isActive)
        {
            this.Username = username;
            this.Password = password;
            this.Age = age;
            this.RegistrationDate = registrationDate;
            this.LastLoginTime = lastLoginTime;
            this.IsActive = isActive;
        }

        public string Username
        {
            get
            {
                return this.username;
            }

            set
            {
                this.username = value;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }

            set
            {
                this.password = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                this.age = value;
            }
        }

        public DateTime RegistrationDate
        {
            get
            {
                return this.registrationDate;
            }

            set
            {
                this.registrationDate = value;
            }
        }

        public DateTime LastLoginTime
        {
            get
            {
                return this.lastLoginTime;
            }

            set
            {
                this.lastLoginTime = value;
            }
        }

        public bool IsActive
        {
            get
            {
                return this.isActive;
            }

            set
            {
                this.isActive = value;
            }
        }
    }
}
