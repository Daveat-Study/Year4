5/Sep/22, 9:15-10:45am

1.2 Concept:

	d). What is the difference between SE and computer science?

		- CS is concerned with theory and fundamentals
		- SE is concerned with the practicalities of the developing and delivering useful software ( Lan Sommerville).

	e). What is the difference between SE and system engineering?
		- System engineering is concerned with all aspects of computer-based systems development, including hardware, software and process engineering.
		- SE is just part of this process in System Engineering.

	f). What is a SW process? 
		+ សំណុំនៃ Process SW Process is a set of activities whoses goal is the development or evolution of software, Thease activities are:
			- SW specification: (កំណត់ឬវិភាគមុខងារ) the functionality of the software and constraints on its operation must be defined.

			+ Why are software process models importance?
			- SW Developemnt: the software to meet the specification must be produced.
			- SW Validation: (បញ្ចាក់ភាពត្រឺមត្រូវដើម្បីធានាថាដំណើរការដូចអតិចិជនចង់បាន) the software must be validated to ensure that it does what the customer wants.
			- SW Evolution or maintenance: the software must evolve tot meet chaning customer needs.
	
	g). SW Characteristics:
		- Software is developed or engineered, it is not manufactured in the classical sens.
		- Most software is custom-build, rather than being assembled from existing components.
		- SW គឺជាទំនីញដែលគ្មានរូប មើលមិនឃើញ.
		- SW doesn't "wear out": ពុំមានសំណឹក។គុណភាពរបស់វាមាននិន្នាការល្អឡើងក្រោយពីមានកំហុសម្តងៗត្រូវបានរកឃើញនិងកែតម្រូវ។
		- SW តែងមានកំហុសបង្កប់នៅក្នុងនោះតាមទ្រង់ទ្រាយកាន់តែធំលទ្ធភាពផ្ទុកកំហុសក៏កាន់តែធំដែរ។
		- កំហុសនៃ SW ងាយប្រទះឃើញដោយអ្នកមកពីខាងក្រៅ។
		- Sw តែងតែផ្ទុកដោយគំនិតនិងការឆ្នៃប្រឌិតនៃអ្នកសរសេរឬក្រុមបង្កើតវា។
		- អាចធ្វើការ Copy ដោយសាមញ្ញបំផុត។

--------------------------------------------

1/Sep/22, 7:30-9am

1.2 Concept:

Continue
	c) SW quality (Software quality):
		+ Attributes of SW quality:

			2). Maintainability: the degree to which a program is amenable to change
			
				+ Does it easy to maintenance?
				- Not Easy

				+ Measure of Maintainability:

					- MTTC(Mean-TIme to Change): រយះពេលជាមធ្យមក្នុងការផ្លាស់ប្តូរ.
						- MTTC កាន់តែខ្ពស់អត់ល្អ.
						- MTTC កាន់តែទាបគឺកាន់តែល្អ.

						- ខ្ពស់ទាបជាមួយអ្វី: Compare time develop of Previous version.
			
			3). Integrity: 
				- កំរិតដែលអាចការពារបាននូវការវាយលុកពីខាងក្រៅ
				- the degree to which a program is impervious to outside attack.

				+ តើការវាយលុកពីខាងក្រៅចូល Software Engineering តាមរយះអ្វីខ្លះ?
					- Virus
					- Hacker: ចោរ IT.
			
			4). Usability: the degree to which a program is easy to use.

			5). Efficiency(សន្សំសំចៃ): the degree to which a program uses less CPU-time, memory, disk space, network bandwidth and other resources.

			6). Reliability (កម្រិតជឿជាក់): the degree to which a program has a fewer failures.

			7). Reusability: the degree to which a SW component is reusable if it can be used in several different system with little or no modification.

			+ Conflict:
				- Usability:
				- Efficiency:
				=> Easy to use but high space will effect to Efficiency
				=> Less space or low spec but not easy for Usability.

		+ Defect: estimate half or a year.

------------------------------------------

29/Aug/22, 9:15-10:45am

Continue
1.2 Concept:

	b). what is Software Engineering: 
		is establishment and use of sound engineering principles in order to obtain economically software that is reliable and works feeiciently on real.
		the applicatoin of a systematic, disciplined, quantifiable approach to the development, operation, and maintenance of software, that is , the application of engineeringto software.
		the study of approaches as in IEEE

		- Engineering is the systematic application of scientic knowledge in creating and building cost-effective solution to practical problems in the service of manykind.

		+ Any Step:
			- Problem identification
			- Anylysis of the problem.
			- A search for possible alternative solution
			- Evaluation and then choice of the most appropriate solution.
			- Design and Implementation of the solution.

		- Solving customer's problem
		- systematic development and evolution
		- Large, high-quality SW system.
		- Cost, time, and constraints

	c) SW quality (Software quality):

		+ Customer: 
			- solves problem at an acceptable cost in terms of money paid and resources used.
		+ User: 
			- easy to lear, efficient to use. helps get work done.
		+ Developer:
			- easy to design, maintenance, and reuse its
		+ development manager:
			- sells more and pleases customer while costing fees to develop and maintain.	

		+ Attributes of SW quality:

			- correctness(correction): the degree to which a program operates according to specification.

			+ How to measure correctness? 

				=> Formula: Value of Defects/KLOC

					Defects | Error

				- KLOC  (K=Kilo, LOC= Line Of Code)
				- Error: problem occure before using
				- Defect (In Software Engineering Called): problem occure after using

-----------------------------------------

25/Aug/22, 7:30-9am

1.2 Concept:

	+ What is Software?
		+ Software is a set of instructions, written by one or more programming language to perform automatically some functions in solving any problem. 
			- Instuctions (computer programs) that when executed provide desired function and performance.
			- Data structure that enable the programs to adequately manipulate information.
			- Documents that describe the operation and use of the programs.

1.1 The history of S.E

	+ Some of reasons that make software crisis in first software development in 19th century:
		1. Software developers used multiple programming language.
		2. Software developers used multiple variabtions of standard programming language
		3. Most of the requirement were complex with regard to the existing capabilitires.
		4. Users, who had little of no experience of devloping or even using software, formulated requirement.
		5. Software developers poorly mapped requirements to the actual product.
		5. Software developed had low interoperability.
		6. Software maintenance was costly.
		7. Hardware deeloped at a faster rate than software(better hardware requires better software to operate it)
		
	+ In 19th centery some country that define SW (SW Crisis) is 70% in plan that relate Information Technology.

	+ NATO made conference about science in Munich (1968) city to solve those of crisis.  

	+ After crisis: software problem they start birth Software Engineering to solve (SE).

	+ Why SE? - because to solve and prevent problem that can occure in software in the future.
		- Build it correct the first time.
		- Reduce development cost.
		- Reduce development time.
		- Repeat previous successes.
		- Learn from previous failures.

	+ Goal of SE:
		1. To improve the quality of the software products.
		2. To increase the productivity (ផលិតភាព: ភាពដែលអាចផលិតបាន).
		3. To give job satisfaction the the software engineers.

------------------------------------------------------------------------------------

22/Aug/22

+ First day:
	- What?
	- How?
	- Change?	
