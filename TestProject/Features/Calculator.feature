
Feature: Peform Operation On Calculator


	@CloseAllInstance
    Scenario Outline: Check for result for operation
	Given  Calculator is Opened 
	When   : I Select the Mode '<SpecificMode>'
	Then  : I Input 12
	And   : I perform 'add' action
	And   : I Input 999
	And   : I perform 'equal' action
	And   : I perform 'StoreinMemory' action
	And   : I perform 'add' action
	And   : I Input 19
	And   : I perform '<Operation>' action
	And   : The Result is '<Result>'
	

	Examples: 
				| SpecificMode | Operation | Result |
				| Standard     | equal     | 1030   |
				| Scientific   | Square    | 361    |
	