﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRP.Models;
namespace HRP.ViewModels
{
    public class ComplaintVM
    {
        public  string status_name = "";
        public  string complaint_type_name = "";
        public Complaints complaints { get; set; }
        public List<Complaints> lcomplaints { get; set; }
        public List<Status> status { get; set; }
        public List<ComplaintType> complainttype { get; set; }

        public User user { get; set; }

        public List<Position> positions { get; set; }
        public string position_name;
        public Address address { get; set; }

    }
}
