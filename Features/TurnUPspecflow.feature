Feature: This test suite contains test scenarios for Time and Material Page in TurnUpPortal


Scenario:A.Create a new Time and Material record
	Given User logs into TurnUpPortal
	And User navigate to Time and Materials Page
	When User clicks on <<CreateNew>> button
	Then New TM record is created 

	Scenario: B.Edit the newly created TM record
	Given User logs into TurnUpPortal
	And User navigate to Time and Materials Page
	When Edit an existing Time and Material record 
	Then Verify TMrecord is edited
	
	Scenario: C. Delete an existing Time and Material record
	Given User logs into TurnUpPortal
	When User navigate to Time and Materials page
	And User deletes an existing Time and Material record 
	Then Verify TM record is deleted