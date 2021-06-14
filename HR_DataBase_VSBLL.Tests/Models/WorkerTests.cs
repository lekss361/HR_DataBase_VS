using HR_DataBase_VSBLL.Tests.Requests.Worker;
using HR_DataBase_VSDAL.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DataBase_VSBLL.Models
{
    public class WorkerTests
    {
        private MappersController _MappersController;

        [SetUp]
        public void Setup()
        {
            _MappersController = new MappersController();
        }

        [TestCaseSource(typeof(MapWorkerModelToDTOSource))]
        public void GetModelsFromDTO_WhenValidTestPassed_ShouldReturnListLocationModels(List<WorkersDTO> workers, List<WorkersDTO> expected)
        {
            List<Worker> actual = _MappersController.MapWorkersDTOToModels(workers);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetModelsFromDTO_WhenInvaildTestPassed_ShouldReturnArgumentNullException(List<WorkersDTO> workers)
        {
            Assert.Throws<ArgumentNullException>(() => _MappersController.MapWorkersDTOToModels(workers));
        }

        [TestCaseSource(typeof(MapWorkersDTOToModelsSource))]
        public void GetDTOFromModel_WhenValidTestPassed_ShouldReturnLocationDTO(Worker worker, WorkersDTO expected)
        {
            WorkersDTO actual = _MappersController.MapWorkerModelToDTO(worker);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetDTOFromModel_WhenInvaildTestPassed_ShouldReturnArgumentNullException(Worker worker)
        {
            Assert.Throws<ArgumentNullException>(() => _MappersController.MapWorkerModelToDTO(worker));
        }
    }
}
