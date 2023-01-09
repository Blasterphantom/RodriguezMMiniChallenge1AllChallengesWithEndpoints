using Microsoft.AspNetCore.Mvc;
using StudentDircetoryApi.Models;

namespace RodriguezMMiniChallenge1AllChallengesWithEndpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentDirectory : ControllerBase
{
    public List<StudentListModel> studentLists = new List<StudentListModel>()
    {
        //call the constructor
        new StudentListModel(){
            firstName = "Danny",
            lastName = "Tran",
            slackName = "DannyTran",
            email = "dannytran@gmail.com",
            hobbies = "Being an awesome TA"
        },
        new StudentListModel(){
            firstName = "Scott",
            lastName = "Morenzone",
            slackName = "ScottMorenzone",
            email = "scottmorenzone@gmail.com",
            hobbies = "Being an awesome TA too"
        },
        new StudentListModel(){
            firstName = "Ken",
            lastName = "Martinez",
            slackName = "KenMartinez",
            email = "kenmartinez@gmail.com",
            hobbies = "Being an awesome teacher"
        }
    };

    //endpoint that gets a student by their first name
    [HttpGet]
    [Route("GetStudentByFirstName/{studentFirstName}")]

    public StudentListModel GetStudentByFirstName(string studentFirstName)
    {
        StudentListModel result = new StudentListModel();

        for(int i = 0; i<studentLists.Count; i++)
        {
            if(studentLists[i].firstName == studentFirstName)
            {
                result = studentLists[i];
                break;
            }
            else
            {
                result.firstName = "N/A";
                result.lastName = "N/A";
                result.slackName = "N/A";
                result.email = "N/A";
                result.hobbies = "N/A";
            }
        }

        return result;
    }
}