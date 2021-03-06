﻿using System.Xml.Serialization;

namespace ProductShop.App.DTOs.Import
{
    [XmlType("user")]
    public class ImportUserDto
    {
        public ImportUserDto()
        {

        }

        public ImportUserDto(string firstName, string lastName, string age) : this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        [XmlAttribute("firstName")]
        public string FirstName { get; set; }

        [XmlAttribute("lastName")]
        public string LastName { get; set; }

        [XmlAttribute("age")]
        public string Age { get; set; }
    }
}
