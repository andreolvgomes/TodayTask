﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NeedDesk.Application.DTO.Users
{
    public class UserDto
    {
        public Guid Use_id { get; set; }
        public string Use_email { get; set; }
        public DateTime CreateAt { get; set; }
    }
}