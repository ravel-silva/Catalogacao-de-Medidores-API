using CatalogacaoDeMedidores.Data;
using CatalogacaoDeMedidores.Model;
using Microsoft.AspNetCore.Mvc;

namespace CatalogacaoDeMedidores.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogarMedidorController : ControllerBase
    {
        private MedidoresContext _context;

        public CatalogarMedidorController(MedidoresContext context)
        {
            _context = context;
        }
        //cadastro de medidores
        [HttpPost]

        public void CatalogarMedidoresTria([FromBody] CatalogarMedidoresRequest request)
        {
            if (request.MedidorTria != null)
            {
                _context.MedidoresTria.Add(request.MedidorTria);
            }
            if (request.MedidorVeri != null)
            {
                _context.medidoresVeri.Add(request.MedidorVeri);
            }

            _context.SaveChanges();
        }
        //visualização de medidores
        [HttpGet]

        public ActionResult<CatalogarMedidoresResponse> TodosMedidores()
        {
            var todosMedidores = new CatalogarMedidoresResponse
            {
                MedidorTria = _context.MedidoresTria.ToList(),
                MedidorVeri = _context.medidoresVeri.ToList()
            };
            return Ok(todosMedidores);
        }
        [HttpGet("tria")]

        public IEnumerable<MedidoresTria> MedidorTria()
        {
            return _context.MedidoresTria;
        }
        [HttpGet("veri")]
        public IEnumerable<MedidoresVeri> MedidorVeri()
        {
            return _context.medidoresVeri;
        }
        //exclução de medidores
        [HttpDelete("tria/{id}")]

        public ActionResult DeleteMedidorTria(int id)
        {
            var medidor = _context.MedidoresTria.FirstOrDefault(medidor => medidor.Id == id);
            if (medidor == null) return NotFound();
            _context.Remove(medidor);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("veri/{id}")]

        public ActionResult DeleteMedidorVeri(int id)
        {
            var medidor = _context.medidoresVeri.FirstOrDefault(medidor => medidor.Id == id);
            if (medidor == null) return NotFound();
            _context.Remove(medidor);
            _context.SaveChanges();
            return NoContent();
        }
        //atualização de medidores
        [HttpPut("tria/{id}")]

        public ActionResult AtualizaMedidorTria(int id, [FromBody] MedidoresTria novoMedidor)
        {
            var medidorExistente = _context.MedidoresTria.FirstOrDefault(medidor => medidor.Id == id);
            if (medidorExistente == null) return NotFound();

            medidorExistente.NumeroTria = novoMedidor.NumeroTria;
            _context.SaveChanges();
            return NoContent();        
        }

        [HttpPut("veeri/{id}")]

        public ActionResult AtualizaMedidorVeri(int id, [FromBody] MedidoresVeri novoMedidor)
        {
            var medidorExistente = _context.medidoresVeri.FirstOrDefault(medidor => medidor.Id == id);
            if (medidorExistente == null) return NotFound();

            medidorExistente.NumeroVeri = novoMedidor.NumeroVeri;
            _context.SaveChanges();
            return NoContent();
        }
    }
}
