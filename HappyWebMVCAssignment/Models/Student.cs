using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HappyWebMVCAssignment.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required()]
        public string Name { get; set; }
        [Required()]
        public string Code { get; set; }
        [Required()]
        public string Phone { get; set; }
        [Required()]
        public string Email { get; set; }
        public StudentStatus Status { get; set; }
        public enum StudentStatus
        {
            Active = 1,
            DeActive = 0,
            Saved = 2,
            Deleted = 3
        }
        [Required()]
        [Range(0, Double.PositiveInfinity)]
        public int LateCount { get; set; }
        [Required()]
        [Range(0, Double.PositiveInfinity)]
        public double LateMoney { get; set; }
        [Required()]
        [Range(0, Double.PositiveInfinity)]
        public int LatePush { get; set; }

        public int ClassroomId { get; set; }
        public virtual Classroom Classroom { get; set; }
    }
}