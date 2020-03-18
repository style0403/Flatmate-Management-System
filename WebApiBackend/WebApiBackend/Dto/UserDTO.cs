﻿using System;
using WebApiBackend.Interfaces;

namespace WebApiBackend.Dto
{
    public class UserDTO : IEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string MedicalInformation { get; set; }
        public string BankAccount { get; set; }
        public string HashedPassword { get; set; }

        public UserDTO(Model.User user)
        {
            UserName = user.UserName;
            FirstName = user.FirstName;
            LastName = user.LastName;
            DateOfBirth = user.DateOfBirth;
            PhoneNumber = user.PhoneNumber;
            Email = user.Email;
            MedicalInformation = user.MedicalInformation;
            BankAccount = user.BankAccount;
        }
    }
}
