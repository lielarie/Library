using DAL;
using Models.Enums;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BL
{
    public class Logic
    {
        private readonly IRepository rep = new Repository();
        public InformationLogic infoLogic = new InformationLogic();
        public UserLogic userLogic = new UserLogic();
        public ItemLogic itemLogic = new ItemLogic();

        public Logic() { }
    }
}
