﻿using PG.Api.Domains.Base;

namespace PG.Api.Domains.UserProfile
{
    public class EditUserProfileDto : BaseDto<Model.UserProfile>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}