using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Infrastructure.Constants
{
    /// <summary>
/// Constants for validation of models
/// </summary>
    public static class ValidationConstants
    {
        public const int MinimumTitleLength = 10;
        public const int MaximumTitleLength = 50;
        public const int MinimumContentLength = 30;
        public const int MaximumContentLength = 1500;

    }
}
