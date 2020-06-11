using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEUVideo.Transaction
{
    class VideoBLL
    {
        //BLL Bussiness Logic Layer
        //Capa de Logica del Negocio

        public static void Create(Video a)
        {
            using (dbPortalVideosEntities db = new dbPortalVideosEntities())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Video.Add(a);
                        db.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public static Video Get(int? id)
        {
            dbPortalVideosEntities db = new dbPortalVideosEntities();
            return db.Video.Find(id);
        }

        public static void Update(Video alumno)
        {
            using (dbPortalVideosEntities db = new dbPortalVideosEntities())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Video.Attach(alumno);
                        db.Entry(alumno).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public static void Delete(int? id)
        {
            using (dbPortalVideosEntities db = new dbPortalVideosEntities())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        Video alumno = db.Video.Find(id);
                        db.Entry(alumno).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public static List<Video> List()
        {
            dbPortalVideosEntities db = new dbPortalVideosEntities();
            return db.Video.ToList();
        }
    }
}
