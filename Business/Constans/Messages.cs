using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.DTOs;

namespace Business.Constans
{
    public static class Messages
    {
        public static string CategoryAdded = "Kategori eklendi.";

        public static string CourseListed = "Kurs detayları listelendi.";

        public static string ErrorMessage = "Sistem bakımda.";

        internal static string CategoryDeleted = "Kategori silindi.";

        internal static string CategoriesListed = "Kategoriler listelendi.";

        internal static string CategoryUpdated = "Kategori güncellendi.";
        internal static string CourseError;
        internal static string CourseAdded;
        internal static string CourseDeleted;
        internal static string CourseModified;
    }
}
