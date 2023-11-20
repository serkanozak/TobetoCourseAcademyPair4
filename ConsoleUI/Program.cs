using Business.Concretes;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;

class Program
{



    static void Main(string[] args)
    {


        //Home();
        CourseDetail();
    }


    public static void CourseDetail()
    {
        CourseManager courseManager = new CourseManager(new EfCourseDal());

        Console.WriteLine(courseManager.GetCourseDetails().Message);

    }


    public static void Home()
    {
        Console.Write(" —ANA MENU —-: \n 1-Admin \n 2-Kullanıcı ");
        Console.Write("seciminizi giriniz: ");
        int secim = int.Parse(Console.ReadLine());
        switch (secim)
        {
            case 1:
                Admin();
                break;

            case 2:
                Kullanıcı();
                break;

            default: Console.WriteLine("yanlis secim yaptiniz, lüten gecerli bir secim yapiniz: "); Home(); break;
        }
        void Admin()
        {
            Console.Write(" —ANA MENU —-: \n 1-Category ekle \n 2-Kullanıcı ");
            Console.Write("seciminizi giriniz: ");
            int secim = int.Parse(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    AddCategory();
                    break;

                case 2:
                    DeleteCategory();
                    break;
                case 3:
                    UpdateCategory();
                    break;

                default: Console.WriteLine("yanlis secim yaptiniz, lüten gecerli bir secim yapiniz: "); Admin(); break;
            }

        }
        void Kullanıcı()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());


            foreach (var category in categoryManager.GetAll())

            {
                Console.Write(category.CategoryId + "-) ");


                Console.WriteLine(category.CategoryName);


            }
        }


        //admin panel
        //kullanıcı




    }

    private static void UpdateCategory()
    {
        throw new NotImplementedException();
    }

    private static void DeleteCategory()
    {
        Category category = new Category();
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

        string categoryAdmin;
        Console.WriteLine("Category ismini giriniz");
        categoryAdmin = Console.ReadLine();
        category.CategoryName = categoryAdmin;
        for (int i = 2; i == i + 1; i++)
        {
            category.CategoryId = i;

        }


        categoryManager.Add(category);

        foreach (var categorys in categoryManager.GetAll())

        {
            Console.Write(categorys.CategoryId + "-) ");


            Console.WriteLine(categorys.CategoryName);


        }
    }

    private static void AddCategory()
    {
        Category category = new Category();
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        string categoryAdmin;
        Console.WriteLine("Category ismini giriniz");
        categoryAdmin = Console.ReadLine();
        category.CategoryName = categoryAdmin;
        for (int i = 1; i == i + 1; i++)
        {
            category.CategoryId = i;

        }


        categoryManager.Add(category);

        foreach (var categorys in categoryManager.GetAll())

        {
            Console.Write(categorys.CategoryId + "-) ");


            Console.WriteLine(categorys.CategoryName);


        }
    }
}









