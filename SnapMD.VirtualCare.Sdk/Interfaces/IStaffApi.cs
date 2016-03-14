﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnapMD.VirtualCare.ApiModels;
using SnapMD.VirtualCare.Sdk.Models;

namespace SnapMD.VirtualCare.Sdk.Interfaces
{
    public interface IStaffApi
    {
        /// <summary>
        /// Creates a new staff profile with the parameters passed in request
        /// </summary>
        /// <param name="request">Request to create the new staff profile</param>
        /// <returns></returns>
        ApiResponseV2<CreateStaffProfileResponse> NewStaffProfile(StaffAccountModelRequest request);
    }
}
