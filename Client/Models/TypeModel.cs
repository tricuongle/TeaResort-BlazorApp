﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace SmartRetail.Client.Models
{
    public enum SERVER_TYPES
    {
        Enum, //0
        Integer, //1
        String, //2
        Array, //3
        Double, //4
        TimeSpan, //5
        Date, //6
        Bool//7

    }

    public enum BacnetObjectTypes : uint
    {
        OBJECT_ANALOG_INPUT = 0,
        OBJECT_ANALOG_OUTPUT = 1,
        OBJECT_ANALOG_VALUE = 2,
        OBJECT_BINARY_INPUT = 3,
        OBJECT_BINARY_OUTPUT = 4,
        OBJECT_BINARY_VALUE = 5,
        OBJECT_CALENDAR = 6,
        OBJECT_COMMAND = 7,
        OBJECT_DEVICE = 8,
        OBJECT_EVENT_ENROLLMENT = 9,
        OBJECT_FILE = 10,
        OBJECT_GROUP = 11,
        OBJECT_LOOP = 12,
        OBJECT_MULTI_STATE_INPUT = 13,
        OBJECT_MULTI_STATE_OUTPUT = 14,
        OBJECT_NOTIFICATION_CLASS = 15,
        OBJECT_PROGRAM = 16,
        OBJECT_SCHEDULE = 17,
        OBJECT_AVERAGING = 18,
        OBJECT_MULTI_STATE_VALUE = 19,
        OBJECT_TRENDLOG = 20,
        OBJECT_LIFE_SAFETY_POINT = 21,
        OBJECT_LIFE_SAFETY_ZONE = 22,
        OBJECT_ACCUMULATOR = 23,
        OBJECT_PULSE_CONVERTER = 24,
        OBJECT_EVENT_LOG = 25,
        OBJECT_GLOBAL_GROUP = 26,
        OBJECT_TREND_LOG_MULTIPLE = 27,
        OBJECT_LOAD_CONTROL = 28,
        OBJECT_STRUCTURED_VIEW = 29,
        OBJECT_ACCESS_DOOR = 30,
        OBJECT_TIMER = 31,
        OBJECT_ACCESS_CREDENTIAL = 32,
        OBJECT_ACCESS_POINT = 33,
        OBJECT_ACCESS_RIGHTS = 34,
        OBJECT_ACCESS_USER = 35,
        OBJECT_ACCESS_ZONE = 36,
        OBJECT_CREDENTIAL_DATA_INPUT = 37,
        OBJECT_NETWORK_SECURITY = 38,
        OBJECT_BITSTRING_VALUE = 39,
        OBJECT_CHARACTERSTRING_VALUE = 40,
        OBJECT_DATE_PATTERN_VALUE = 41,
        OBJECT_DATE_VALUE = 42,
        OBJECT_DATETIME_PATTERN_VALUE = 43,
        OBJECT_DATETIME_VALUE = 44,
        OBJECT_INTEGER_VALUE = 45,
        OBJECT_LARGE_ANALOG_VALUE = 46,
        OBJECT_OCTETSTRING_VALUE = 47,
        OBJECT_POSITIVE_INTEGER_VALUE = 48,
        OBJECT_TIME_PATTERN_VALUE = 49,
        OBJECT_TIME_VALUE = 50,
        OBJECT_NOTIFICATION_FORWARDER = 51,
        OBJECT_ALERT_ENROLLMENT = 52,
        OBJECT_CHANNEL = 53,
        OBJECT_LIGHTING_OUTPUT = 54,
        OBJECT_BINARY_LIGHTING_OUTPUT = 55,
        MAX_ASHRAE_OBJECT_TYPE = 56,
        OBJECT_PROPRIETARY_MIN = 128,
        OBJECT_PROPRIETARY_MAX = 1023,
        MAX_BACNET_OBJECT_TYPE = 1024
    }

}
