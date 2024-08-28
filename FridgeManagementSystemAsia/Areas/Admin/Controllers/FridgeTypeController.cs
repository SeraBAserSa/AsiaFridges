using AsiaFridges.DataAccess.Data;
using AsiaFridges.DataAccess.Repository.IRepository;
using AsiaFridges.Models;
using Microsoft.AspNetCore.Mvc;


namespace FridgeManagementSystemAsia.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FridgeTypeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public FridgeTypeController(IUnitOfWork unitOfWork) //: base(db)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()

        {
            List<FridgeType> objFridgeTypeList = _unitOfWork.FridgeType.GetAll().ToList();
            return View(objFridgeTypeList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(FridgeType obj)
        {
            if (obj.FridgeTypeName == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("FridgeTypeName", "The Display Order cannot exactly match the fridge type name");
            }


            if (ModelState.IsValid)
            {
                _unitOfWork.FridgeType.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Fridge Type created successfully";
                return RedirectToAction("Index");

            }
            return View();

        }

        public IActionResult Edit(int? FridgeTypeID)
        {
            if (FridgeTypeID == null || FridgeTypeID == 0)
            {
                return NotFound();
            }

            FridgeType? fridgeTypeFromDb = _unitOfWork.FridgeType.Get(u => u.FridgeTypeID == FridgeTypeID);
            //FridgeType? fridgeTypeFromDb = _fridgeTypeRepo.FirstOrDefault(u=>u.FridgeTypeID)
            if (fridgeTypeFromDb == null)
            {
                return NotFound();
            }
            return View(fridgeTypeFromDb);
        }
        [HttpPost]
        public IActionResult Edit(FridgeType obj)
        {




            if (ModelState.IsValid)
            {
                _unitOfWork.FridgeType.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "Fridge Type updated successfully";
                return RedirectToAction("Index");

            }
            return View();

        }

        public IActionResult Delete(int? FridgeTypeID)
        {
            if (FridgeTypeID == null || FridgeTypeID == 0)
            {
                return NotFound();
            }

            FridgeType? fridgeTypeFromDb = _unitOfWork.FridgeType.Get(u => u.FridgeTypeID == FridgeTypeID);

            if (fridgeTypeFromDb == null)
            {
                return NotFound();
            }
            return View(fridgeTypeFromDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? FridgeTypeID)
        {
            FridgeType? obj = _unitOfWork.FridgeType.Get(u => u.FridgeTypeID == FridgeTypeID);

            if (obj == null)
            {
                return NotFound();
            }

            _unitOfWork.FridgeType.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "Fridge Type Deleted successfully";

            return RedirectToAction("Index");
        }
    }
}

