using System;
using TechTalk.SpecFlow;

namespace CodedUITestProject2
{
    [Binding]
    public class CreateSubTaskSteps
    {
        [Given(@"I have clicked the '(.*)' button")]
        public void GivenIHaveClickedTheButton(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"a modal dialog opened")]
        public void GivenAModalDialogOpened()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered less than (.*) characters in the SubTask Description field")]
        public void GivenIHaveEnteredLessThanCharactersInTheSubTaskDescriptionField(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered the SubTask due date in the MM/dd/yyyy format")]
        public void GivenIHaveEnteredTheSubTaskDueDateInTheMMDdYyyyFormat()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I click on the add button to add a new Subtask")]
        public void GivenIClickOnTheAddButtonToAddANewSubtask()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the modal dialog should have a read only field with the task ID and the task description")]
        public void ThenTheModalDialogShouldHaveAReadOnlyFieldWithTheTaskIDAndTheTaskDescription()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Subtasks that were added should be appended on the bottom part of the modal dialog")]
        public void ThenSubtasksThatWereAddedShouldBeAppendedOnTheBottomPartOfTheModalDialog()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
