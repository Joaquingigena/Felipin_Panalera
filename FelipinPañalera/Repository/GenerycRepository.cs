using FelipinPañalera.Data;
using FelipinPañalera.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FelipinPañalera.Repository
{
    public abstract class GenerycRepository <TEntidad,TContexto> : IGenerycRepository<TEntidad>
        where TContexto : DbContext
        where TEntidad: class
    {
        public readonly DbContext _context;

        public GenerycRepository(DbContext context)
        {
            _context = context;
        }

        public async Task<string> Crear(TEntidad entidad)
        {
            try
            {
                await _context.Set<TEntidad>().AddAsync(entidad);

                await _context.SaveChangesAsync();

                return "OK";
            }
            catch (Exception err)
            {
                
                return err.ToString();
            }
        }

        public async Task<string> Eliminar(int id)
        {
            try
            {
                var entidad = await _context.Set<TEntidad>().FindAsync(id);

                if (entidad == null)
                {
                    return "No se encontro.";
                }

                _context.Set<TEntidad>().Remove(entidad);
                await _context.SaveChangesAsync();

                return "OK";
            }
            catch (Exception ex)
            {

                return ex.ToString();
            }
        }

        public async Task<List<TEntidad>> Listar()
        {
            try
            {
                var lista = await _context.Set<TEntidad>().ToListAsync();

                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<string> Modificar(int id,TEntidad entidad)
        {
            try
            {
                var obj = await _context.Set<TEntidad>().FindAsync(id);

                if (obj == null)
                {
                    return "No se encontro.";
                }
                

                _context.Entry(obj).CurrentValues.SetValues(entidad);
                await _context.SaveChangesAsync();

                return "OK";
            }
            catch (Exception ex)
            {

                return ex.ToString();
            }
        }

        public async Task<TEntidad> ObtenerUno(int id)
        {
            try
            {
                var entidad= await _context.Set<TEntidad>().FindAsync(id);

                return entidad;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
