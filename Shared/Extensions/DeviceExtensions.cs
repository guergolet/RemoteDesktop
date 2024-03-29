﻿using Remotely.Shared.Dtos;
using Remotely.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Remotely.Shared.Extensions
{
    public static class DeviceExtensions
    {
        private static JsonSerializerOptions _serializerOptions = new()
        {
            PropertyNameCaseInsensitive = true
        };

        /// <summary>
        /// A helper method for creating a DeviceClientDto from a Device entity.
        /// </summary>
        /// <param name="device"></param>
        /// <returns></returns>
        public static DeviceClientDto ToDto(this Device device)
        {
            var json = JsonSerializer.Serialize(device, _serializerOptions);
            return JsonSerializer.Deserialize<DeviceClientDto>(json, _serializerOptions);
        }
    }
}
