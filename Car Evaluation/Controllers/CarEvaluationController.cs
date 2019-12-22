using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Car_Evaluation.Models;
using Car_EvaluationML.Model;

namespace Car_Evaluation.Controllers
{
    public class CarEvaluationController : Controller
    {
        private readonly ILogger<CarEvaluationController> _logger;

        public CarEvaluationController(ILogger<CarEvaluationController> logger)
        {
            _logger = logger;
        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(ModelInput input)
        {
            ModelOutput prediction=ConsumeModel.Predict(input);
            ViewBag.Prediction = prediction;
            return View();
        }
    }
}
