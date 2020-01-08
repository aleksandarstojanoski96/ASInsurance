using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija.Core.Custom_Attributes
{
    
        public class CurrentDateAttribute : ValidationAttribute
        {
            public CurrentDateAttribute()
            {
            }

            public override bool IsValid(object value)
            {
                var dt = (DateTime)value;
                if (dt >= DateTime.Now)
                {
                    return true;
                }
                return false;
            }
        }
    }
