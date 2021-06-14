using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.DTO;
using HR_DataBase_VSDAL.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DataBase_VSBLL.Tests.Mock
{
    class MapControllerMocks
    {
        public class MapCommentsModelToDTO_Source : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new object[] { new Comments { WorkersID = 1, Comment = "sss", Date = "13.06.2021" },
                                            new CommentsDTO{WorkersID = 1, Comment = "sss", Date = "13.06.2021" } };

                yield return new object[] { new Comments { WorkersID = 0, Comment = "", Date = "" },
                                            new CommentsDTO{WorkersID = 0, Comment = "", Date = "" } };
                yield return new object[] { new Comments (),
                                            new CommentsDTO() };
            }
        }
        public class MapCompaniesModelToDTO_Source : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new object[] { new Company { Id = 1, Name = "sss", Information = "ccc",ContactID=1,LocationID=1 },
                                            new CompaniesDTO{Id = 1, Name = "sss", Information = "ccc",ContactID=1,LocationID=1} };

                yield return new object[] { new Company { Id = 0, Name = "", Information = "",ContactID=0,LocationID=0 },
                                            new CompaniesDTO{Id = 0, Name = "", Information = "",ContactID=0,LocationID=0 } };
                yield return new object[] { new Company (),
                                            new CompaniesDTO() };
            }
        }
        public class MapCompanyWithForeignKeyValueDTOToModel_Source : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new object[] { new CompanyWithForeignKeyValueDTO {id=1,ContactID=1,LocationID=1,Name="OOO",Information="dddd"

                                            ,Phone="+78999999",Email="dddd@mail.ru",ContactInformation="ddd",Country="ddd",City="aasd",Street="dddee"
                                            ,HouseNumber="12",ApartmentNumber="52",LocationIndex="ddder"},
                                            new CompanyWithForeignKeyValue{id=1,ContactID=1,LocationID=1,Name="OOO",Information="dddd"

                                            ,Phone="+78999999",Email="dddd@mail.ru",ContactInformation="ddd",Country="ddd",City="aasd",Street="dddee"
                                            ,HouseNumber="12",ApartmentNumber="52",LocationIndex="ddder" } };

                yield return new object[] { new CompanyWithForeignKeyValueDTO { id=0,ContactID=0,LocationID=0,Name="",Information=""

                                            ,Phone="",Email="",ContactInformation="",Country="",City="",Street=""
                                            ,HouseNumber="",ApartmentNumber="",LocationIndex="" },

                                            new CompanyWithForeignKeyValue{id=0,ContactID=0,LocationID=0,Name="",Information=""

                                            ,Phone="",Email="",ContactInformation="",Country="",City="",Street=""
                                            ,HouseNumber="",ApartmentNumber="",LocationIndex="" } };
                yield return new object[] { new CompanyWithForeignKeyValueDTO (),
                                            new CompanyWithForeignKeyValue() };
            }
        }

        public class MapCompaniesWithContactAndLocationDTODTOToModel_Source : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new Object[] {new  List<CompaniesWithContactAndLocationDTO>(),
                                           new List<CompaniesWithContactAndLocation>()};
            }
        }

        public class MapCompaniesDTOToModel_Source : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new Object[] {new  List<CompaniesDTO>(),
                                           new List<Company>()};
            }
        }

        public class MapContactsDTOToModel_Source : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new Object[] {new  ContactsDTO(),
                                           new  Contacts()};
            }
        }

        public class MapContactsModelToDTO_Source : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new Object[] {new  Contacts(),
                                           new  ContactsDTO()};
            }
        }

        public class MapDirectionsModelToDTO_Source : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new Object[] {new  Directions(),
                                           new  DirectionsDTO()};
            }
        }

        public class MapDirectionsDTOToModel_Source : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new Object[] {new  List<DirectionsDTO>(),
                                           new  List<Directions>()};
            }
        }


        public class MapDivisionByCompanyDTOToModel_Source : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new Object[] {new  List<DivisionByCompanyDTO>(),
                                           new  List<DivisionByCompany>()};
            }
        }


        public class MapDivisionWithForeignKeyValueDTOToModel_Source : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new Object[] {new  DivisionWithForeignKeyValueDTO(),
                                           new  DivisionWithForeignKeyValue()};
            }
        }

        public class MapDivisionsModelToDTO_Source : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new Object[] {new  Divisions(),
                                           new  DivisionsDTO()};
            }
        }

        public class MapLocationModelToDTO_Source : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new Object[] {new  Location(),
                                           new  LocationDTO()};
            }
        }

        public class MapLocationDTOToModel_Source : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new Object[] {new  LocationDTO(),
                                           new  Location()};
            }
        }

        public class MapLocationDTOToModelList_Source : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new Object[] {new  List<LocationDTO>(),
                                           new  List<Location>()};
            }
        }


        public class MapPositionsWithDirectionNameDTOToModel_Source : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new Object[] {new  List<PositionsWithDirectionNameDTO>(),
                                           new  List<PositionsWithDirectionName>()};
            }
        }


        public class MapPreviousWorkmodelToDTO_Source : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new Object[] {new  PreviousWork(),
                                           new  PreviousWorkDTO()};
            }
        }


        public class MapProjectModelToDTO_Source : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new Object[] {new  Project(),
                                           new  ProjectDTO()};
            }
        }


        public class MapProjectMapsModelsToDTO_Source : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new Object[] {new  ProjectMaps(),
                                           new  ProjectMapsDTO()};
            }
        }


        public class MapProjectsWithDirectionNameDTOToModel_Source : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new Object[] {new  List<ProjectsWithDirectionNameDTO>(),
                                           new  List<ProjectsWithDirectionName>()};
            }
        }


        public class MapSkillNameWithTypeDTOToModel_Source : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new Object[] {new  List<SkillNameWithTypeDTO>(),
                                           new  List<SkillNameWithType>()};
            }
        }

        public class MapSkillNameWithTypeModelToDTO_Source : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new Object[] {new  SkillNameWithType(),
                                           new  SkillNameWithTypeDTO()};
            }
        }

        public class MapStatusesModelsToDTO_Source : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new Object[] {new  Statuses(),
                                           new  StatusesDTO()};
            }
        }


        public class MapWorkerModelToDTO_Source : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new Object[] {new  Worker(),
                                           new  WorkersDTO()};
            }
        }


        public class MapWorkersDTOToModels_Source : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new Object[] {new  List<WorkersDTO>(),
                                           new  List<Worker>()};
            }
        }
    }
}
