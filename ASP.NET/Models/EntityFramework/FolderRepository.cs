using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASP.NET.Models.EntityFramework
{
    public class FolderRepository
    {

        ApplicationContext _context;

        public FolderRepository(ApplicationContext context)
        {
            _context = context;            
        }

        public FolderRepository()
        {
            _context = new ApplicationContext();
        }

        public Folder GetRoot()
        {
            var root = _context.Folders.FirstOrDefault(folder => folder.IsRoot);
            root.Childs = GetFolderChilds(root.ID);
            root.Path = root.Name + "/";

            return root;
        }

        public Folder GetFolderWithChilds(int id)
        {
            var parent = _context.Folders.FirstOrDefault(folder => folder.ID == id);
            parent.Childs = GetFolderChilds(parent.ID);
            parent.Path = GetPath(parent);

            return parent;
        }

        private string GetPath(Folder currentNode)
        {
            string path = string.Empty;
            while(!currentNode.IsRoot)
            {
                path = currentNode.Name + "/" + path;
                currentNode = _context.Folders.FirstOrDefault(folder => folder.ID == currentNode.ParentID);
            }
            path = _context.Folders.First(folder => folder.IsRoot).Name + "/" + path;

            return path;
        }

        private List<Folder> GetFolderChilds(int id)
        {
            return _context.Folders.Where(folder => folder.ParentID == id).ToList();
        }
    }
}