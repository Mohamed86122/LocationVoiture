using LocationVoiture.Mappers;
using LocationVoiture.Models;
using LocationVoiture.Repository;
using LocationVoiture.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocationVoiture.Controllers
{
    public class VoituresController : Controller
    {
        private readonly IVoitureRepository _voitureRepository;
        private readonly VoitureMapper _voitureMapper;

        public VoituresController(IVoitureRepository voitureRepository, VoitureMapper voitureMapper)
        {
            _voitureRepository = voitureRepository;
            _voitureMapper = voitureMapper;
        }

        // GET: Voitures
        public async Task<IActionResult> Index()
        {
            var voitures = await _voitureRepository.GetAllVoituresAsync();
            // Ici vous pouvez mapper les données vers un ViewModel si nécessaire
            return View(voitures);
        }

        // GET: Voitures/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var voiture = await _voitureRepository.GetVoitureByIdAsync(id);
            if (voiture == null)
            {
                return NotFound();
            }
            // Mappez vers un ViewModel si nécessaire
            return View(voiture);
        }

        // GET: Voitures/Create
        public IActionResult Create()
        {
            // Préparez tout ViewModel nécessaire pour la création
            return View();
        }

        // POST: Voitures/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(VoitureVm voitureVm)
        {
            if (ModelState.IsValid)
            {
                var voiture = _voitureMapper.AddVoitureMap(voitureVm);
                await _voitureRepository.AddVoitureAsync(voiture);
                return RedirectToAction(nameof(Index));
            }
            // Gérez ici l'état non valide et renvoyez à la vue avec les données saisies
            return View(voitureVm);
        }

        // GET: Voitures/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var voiture = await _voitureRepository.GetVoitureByIdAsync(id);
            if (voiture == null)
            {
                return NotFound();
            }
            // Mappez l'entité vers le ViewModel ici
            var voitureVm = new VoitureVm
            {
                // Initialisation des propriétés à partir de l'entité voiture
            };
            return View(voitureVm);
        }

        // POST: Voitures/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, VoitureVm voitureVm)
        {
            
            if (ModelState.IsValid)
            {
                var voiture = _voitureMapper.AddVoitureMap(voitureVm);
                await _voitureRepository.UpdateVoitureAsync(voiture);
                return RedirectToAction(nameof(Index));
            }
            // Gérez ici l'état non valide et renvoyez à la vue avec les données saisies
            return View(voitureVm);
        }

        // GET: Voitures/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var voiture = await _voitureRepository.GetVoitureByIdAsync(id);
            if (voiture == null)
            {
                return NotFound();
            }
            return View(voiture);
        }

        // POST: Voitures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _voitureRepository.DeleteVoitureAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
