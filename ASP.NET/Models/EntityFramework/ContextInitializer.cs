using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;

namespace ASP.NET.Models.EntityFramework
{
    class ContextInitializer : CreateDatabaseIfNotExists<ApplicationContext>
    {
        protected override void Seed(ApplicationContext db)
        {
            #region Create test data

            Folder root = new Folder() { IsRoot = true, Name = "Creating Digital Images" };
            Folder Evidence = new Folder { Name = "Evidence", Parent = root };
            Folder resourses = new Folder { Name = "Resourses", Parent = root };
            Folder grProducts = new Folder { Name = "Graphic Products", Parent = root };
            Folder process = new Folder { Name = "Procces", Parent = grProducts };
            Folder finalProduct = new Folder { Name = "Final Product", Parent = grProducts };
            Folder primarySourses = new Folder { Name = "Primary Sourses", Parent = resourses };
            Folder secondarySourses = new Folder { Name = "Secondary Sourses", Parent = resourses };
            List<Folder> testFolders = new List<Folder>() { root, Evidence, resourses, grProducts, process, finalProduct, primarySourses, secondarySourses };
            foreach(var fold in testFolders)
            {
                db.Folders.Add(fold);
            }

            #endregion
        }

    }
}