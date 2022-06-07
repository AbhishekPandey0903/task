using Microsoft.EntityFrameworkCore;
using ApiTask1.Models;

namespace ApiTask1.Repository
{
    public interface TaskInterface
    {
        List<ModApi> Get();
        bool Create(ModApi Mac);
        ModApi Edit(int id);
        bool Delete(int id);
        
    }

    public abstract class TaskData : TaskInterface

    {
        public abstract List<ModApi> Get();

        public abstract bool Create(ModApi Mac);

        public abstract bool Delete(int id);

        public abstract ModApi Edit(int id);

       
    }

    public class ITaskRepository : TaskData
    {

        private readonly ModContext dbcontext = null;

        public override bool Create(ModApi Mac)
        {
            if (Mac == null)
            {
                return false;
            }
            else
            {
                if (Mac == null)
                {
                    return false;
                }
                else
                {
                    if (Mac.Id == 0)
                    {
                        dbcontext.TabT.Add(Mac);
                        dbcontext.SaveChanges();
                        return true;
                    }
                    else
                    {
                        dbcontext.Entry(Mac).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        dbcontext.SaveChanges();
                        return true;
                    }
                }
               
                
            }
        }
           
        public ITaskRepository(ModContext _db)
        {
            dbcontext = _db;
        }

        public override List<ModApi> Get()
        {
            return dbcontext.TabT.ToList();
        }
        public override bool Delete(int id)
        {

            var student = dbcontext.TabT.Find(id);
            if(student == null)
            {
                return false;
            }
            else
            {
                dbcontext.TabT.Remove(student);
                dbcontext.SaveChangesAsync();
                return true;
            }
            
        }
        public override ModApi Edit(int id)
        {
            return dbcontext.TabT.Find(id);
        }

    }
}

