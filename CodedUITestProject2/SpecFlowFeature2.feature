Feature: Create SubTask
    As a ToDo App user
    I should be able to create a subtask
    So I can break down my tasks in smaller pieces
   
@mytag
Scenario: The user should see a button labeled as ‘Manage Subtasks’
    Given I have clicked the 'Manage Subtasks' button 
    And a modal dialog opened
    Then the modal dialog should have a read only field with the task ID and the task description
    Given I have entered less than 251 characters in the SubTask Description field
    And I have entered the SubTask due date in the MM/dd/yyyy format
    And I click on the add button to add a new Subtask
    Then Subtasks that were added should be appended on the bottom part of the modal dialog