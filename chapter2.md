#### 3/Oct/22, 9:15-10:45am

##### 5. <u> Evolutionary Software Process Model. </u>

Model that:
> - ជំនាន់ទៅ១ជំនាន់កាន់តែធំជាងមុន
> - ensure good quality
> - Old features still in there

a. <u> Incremental Model: </u>

##### 4. The RAD (Rapid Application Development) Model:

* <u>Data Modeling:</u>

	- Data to help business are established

	+ In data modeling have 3 section:

		- Data objects.

		- Data attributes

		- Data relationship.

		1. <u> Process modeling: </u>

			- 4GT: The 4th Generation Techiques
			- 4GL: The 4th Generation Languages

		3. <u> CASE: Computer_Aided Software Engineering (Assisted) </u>

			is software to support development software and evolution processes.

		4. <u> Activity automation: </u>
			- Graphical editors for system model development. 
			- Data dictioinary to manange design entities.
			- Graphical UI builder for UI construction.
			- Debuggers to support program fault finding.
			- Automated translators to generate new version of a program.

		5. <u> Testing and Turnovers: </u>

			- Testing and examine each interface.

* <u> RAD: Drawback </u>

	- Need a lot of source (people) to do RAD model.

	- Required developer and customer make agreement in short time.

	- RAD model can't apply all application such as:
	
		- Application that can't split into Module .
		- Application that require high performance.
		- Application that have risk on highly technical

--------------------------------------------
#### 22/Sep/22, 7:30-9am

##### 4. <u> The RAD (Rapid Application Development) Model: </u>

- The RAD Model is hight-speed adaptation of the linear sequential model.
- Project requirement must understood and scope tightly constrainted.
- Developer able to user component-based to build fully functional system in short time perioud.
+ RAD Model មានលក្ខណៈ 
	- Incremental software development: កើនឡើងជាជំហានៗ 60-90ថ្ងៃ.
	- Component-based construction: ប្រើប្រាស់ឡើងវិញ (reusability) 
	* លឿនផ្អែកទៅលើ Component ដែលមានស្រាប់
	* RAD Model spend a lot money.
	* RAD Model work as teams.
	
		1. Teams should consist 6 people such as:

			- Developer
			- Full-time user: because need to complete project short time.
			- Might plus anyone else who has a stake in the requirement.

		2. Developers should be multi-talented "renaissance":
		
			+ Why don't separete designer, Analysis, developer?
			=> Because to prevent freeze task when something wrong happen such as developer sick...	
			* Business modeling.
				+ is information flow to make a model and answer some question below:
					- What information drives the Business process?
					- What information is generated?
					- Who generates it?
					- Where does the information go? or where those information keep?
					- Who processes it? 

- វិភាគសង្កេត 
- វិភាគសួរនាំ

--------------------------------------------

#### 19/Sep/22, 9:15-10:45am

4). <u> The RAD (Rapid Application Development) Model: </u>

	Team #1
	
	| Business Modeling | 
			| Data Modeling |
					| Process Modeling |
							| Application Generation |
									| Testing & Turnover |

3). <u> The Prototyping Model (Throw away Model): </u>

	- Listen to customer  ---------> Build/Revise mock-up
					\                    /
						\                  /
						\ Customer test  /
						>    driver    <
							mock-up

	- Objective is to understand the system requirement.
	- Should start with poorly understand requirement to clarify what is really needs.
	- You use this model when the client is not clear about requirement.
	- To resolve the conflict, devs team develops a working model that client become defined.


	| Requirement |
	| Analysis    |
	| Design      | =>  | Design | => | Code | => | Test | => | implementation |
	| Coding      |
	| Testing     |

+ តើត្រូវត្វើ Prototyping model តៅតេលណា?

	- When we know some objective of software that not clear about Input or Process 
	- Use "The first system" to collect from user via design.
	- Algorithm to do Prototype may slow, not good

2). <u> Linear(បន្ទាត់) Sequential Model : </u>

	- Classic life cycle model or.
	- System development life cycle (SDLC) model.
	
	* | Analysis | -> | Design | -> | Code | -> | Test |

	  _____1_______________2____

	=> 1 & 2= System/Information engineering.

	+ Disadvantage:
		- No maintenance

Continue
2.2. </u> Software Life-Cycle:  </u>

	* The nw additional of SW Life-Cycle:
		1). Requirement definition and design phase:
		2). ជា Phase ដែលធ្វើអោយ SW's structure more ជាក់ស្តែងទៅតាមរបៀប Top-Down.
		3). Design, Coding phase: is the way of Top-down and Testing phase follow the Bottom-up
		4). Make sure current phase is completely test.
		5). Necessary check up again of each phase.
		6). Every phase for later phase but also the critial goal for check and ensure of process and software.

--------------------------------------------
#### 15/Sep/22, 7:30-9am

	Continue:
	2.1. A layered Technology:

		b). A Generic View of SE:

			+ The support (maintenance):
				- Correction: Corrective maintenance
				- Adaptation: Adaptive maintenance
				- Enhancement: Perfective maintenance
				- Prevention: Preventive write code to prevent issue in te future.

	2.2. Software Life-Cycle

		- Cycle: វដ្ដ
		
		=> SW Life-Cycle: គឺជាដំណាក់កាលគិតចាប់ពីពេលដែល SW ត្រូវបានបង្កើតឡើងរហុូតដល់ពេលគេលែងប្រើ (ពីពេលចាប់កកើត ឆ្លើងតបទៅនឹងតម្រូវការ Operate, maintenance រហុូតដល់ពេលបោះបង់ចោលលែងហើយ)

		- SW Life-Cycle: ត្រូវបានចែកជា Phase សំខាន់គឺ Analysis, Design, Coding, Testing, maintenance។ ការសម្ដែងជា phase ទាំងឡាយមានភាពខុសគ្នាទៅតាមមនុស្សម្នាក់ៗ។

		+ Primary function of a software

		+ Why are software process models importance?

			- They provider guidance on the order in which a software development project should carry out its major tasks.

		1). The waterfall Model life Cycle:

--------------------------------------------
#### 12/Sep/22, 9:15-10:45am

2.1. <u> A layered Technology: </u>

a). <u> Process, Methods, and Tools: </u> 

	1. First layer:
		- Process: SE process is the glue that holds the technology layers together and 
			- enables 
			- rational
			- timely.

	2. Second layer:
		- Methods: SE methods provide of  technical how-to's building SW
			- Communication
			- Requirement
			- Design
			- Code
			- Testing
			- Deployment
			- Support

	3. Third layer:
		- Tools: SE tools prvide automated or semi-automated support for the process and the methods.

	4. Forth layer:
		- A quality focus: 

b). <u> A Generic View of SE: </u> 

	* The work associated with SE can be categorized three Generic phases:
		
		+ The definition phase focus on "WHAT":
			- What information is to be processed
			- What function and performance are desired
			- What system behaviro can be expected
			- What interfaces are to be established
			- What design constraints exist
			- What validation criteria are required to define a successful system.	

	* The development phase focus on "HOW":

		- How data are to be structured 
		- How function is to be implementd with a SW architecturee
		- How procedural details are to be implements: refer algorithm.
		- How interface are to be characterized: refer to លក្ខណៈឬមុខងារនៃ interface និមួយៗ.
		- How the design will be translated into programming language: refer to PDL(Programming design language) Pseudocode
		- How testing will be perform
