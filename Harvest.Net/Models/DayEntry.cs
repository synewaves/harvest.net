﻿using RestSharp.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest.Net.Models
{
    [SerializeAs(Name = "day-entry")]
    public class DayEntry : Harvest.Net.Models.IModel
    {
        public long Id { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime CreatedAt { get; set; }

        public string Notes { get; set; }

        public DateTime SpentAt { get; set; }

        public decimal Hours { get; set; }

        public int UserId { get; set; }

        public int ProjectId { get; set; }
        
        public int TaskId { get; set; }

        public bool AdjustmentRecord { get; set; }

        public bool IsBilled { get; set; }

        public bool IsClosed { get; set; }

        /// <summary>
        /// Only supplied by the Daily resource
        /// </summary>
        public DateTime? TimerStartedAt { get; set; }

        /// <summary>
        /// Only supplied by the Daily resource
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Only supplied by the Daily resource
        /// </summary>
        public DateTime? EndedAt { get; set; }

        /// <summary>
        /// Only supplied by the Daily resource
        /// </summary>
        public string Task { get; set; }

        /// <summary>
        /// Only supplied by the Daily resource
        /// </summary>
        public string Project { get; set; }
    }
}
