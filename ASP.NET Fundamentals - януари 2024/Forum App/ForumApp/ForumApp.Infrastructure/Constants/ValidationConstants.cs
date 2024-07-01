using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Infrastructure.Constants
{
    /// <summary>
    /// Validation Constants
    /// </summary>
    public static class ValidationConstants
    {
        /// <summary>
        /// Max Title Length
        /// </summary>
        public const int TitleMaxLength = 50;
        /// <summary>
        /// Min Title Length
        /// </summary>
        public const int TitleMinLength = 10;
        /// <summary>
        /// Max Content Length
        /// </summary>
        public const int ContentMaxLength = 1500;
        /// <summary>
        /// Min Content Length
        /// </summary>
        public const int ContentMinLength = 30;

        /// <summary>
        /// Require Error message text
        /// </summary>
        public const string RequireErrorMessage = "The {0} field is required!";

        public const string StringLengthErrorMessage = "The {0} field must be between {2} and {1} characters long!";
    }
}
