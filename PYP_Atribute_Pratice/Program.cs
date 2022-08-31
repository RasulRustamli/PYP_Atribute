using PYP_Atribute_Pratice.Attributes;
using PYP_Atribute_Pratice.Models;
using PYP_Atribute_Pratice.Validator;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Web.Mvc;

User user = new User();

user.Name = "Rasulll";
user.Email = "saddsasda@gmail.com";
user.Password = "sd2E";

ValidatorService<User> validatorService = new ValidatorService<User>();

Console.WriteLine(validatorService.AttributeCheck(user,typeof(ValidEmail)));




