using NUnit.Framework;
using Moq;
using System;
using System.Collections.Generic;
using HR_DataBase_VSDAL.Models;
using HR_DataBase_VSBLL.Tests.Requests.Comments;

namespace HR_DataBase_VSBLL.Models
{
    public class CommentsTests
    {
        private MappersController _mapper;

        [SetUp]
        public void Setup()
        {
            _mapper = new MappersController();
        }

        [TestCaseSource(typeof(MapCommentsModelToDTOSource))]
        public void GetCommentsModelToDTO_WhenValidTestPassed_ShouldReturnListCommentsDTO(Comments comments, CommentsDTO expected)
        {
            CommentsDTO actual = _mapper.MapCommentsModelToDTO(comments);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void GetModelsFromDTO_WhenInvaildTestPassed_ShouldReturnArgumentNullException(Comments comments)
        {
            Assert.Throws<ArgumentNullException>(() => _mapper.MapCommentsModelToDTO(comments));
        }
    }
}
