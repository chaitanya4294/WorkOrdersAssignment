﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkOrdersAssignmentAPI.Common.DTOs
{
    public class NotificationDTO
    {
        public string Message { get; set; } = string.Empty;
        public string TechnicianRegNum { get; set; } = string.Empty;
    }
}
