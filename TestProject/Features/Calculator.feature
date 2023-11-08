
Feature: Peform Operation On Calculator


@outline
    Scenario Outline: Check for result for operation
	Given  Open the Calculator Application 
	And   : Select the Mode '<SpecificMode>'
	Then  : I Enter '<Numb1>' '<numb2>' and perform add operation
	And   : Then I Click M+
	And   : I Enter on '<numb3>'
	And   : Use square root if its scientific 
	And   : The Result should be '<numb4>'

	

	Examples: 
				| SpecificMode | Numb1 | numb2 | numb4 | numb3
				| Standard     | 12    | 999   | 1030  | 19
				| Scientific   | 12    | 999   | 361   | 19
			