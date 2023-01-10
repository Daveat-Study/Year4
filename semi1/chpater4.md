#### 24/Nov/22, 7:30-9:00am

## <center> <u> Chapter 4 </u> </center>
### <center> <u> Measuring Effort for Software Project </u> </center>

#### <u> 4.3 COCOMO Techniques </u>

COCOMO is used software estimation models in the world.

- Use to predicts the effort and schedule(Duration) for a software product devs.

<u> + COCOMO has three levels: </u>

- Basic
- Intermediate
- Advanced

    <u> a) Basic:</u>
- esitmate the effort and cost of a SW by using only LOC.
- use when we need rough esitmate of effort.
- Estimating the effort in basic COCOMO have three steps:
  1. Estimating total delivered LOC
  2. Determine effort constants based on type project
  3. Substituting values LOC and effort constant in formula.

  Formula:

  - E1 = a1 * (KLOC)of a2. (Effort)
  - D = a3 * (E1)a4. ()
  - P = E1/D

#### <u> FP-Based Estimation </u>

=> Cost per FP = Labor rate/Productivity
=> Total Cost of Project = Cost per FP * Total number of FPs
=> Estimated Effort = Total Cost of Project/Labor rate
=> Duration = Effort/People
=> LOC = AVC * Total number of FPs

#### <u> Using FP for initial Estimation </u>

- To complte on FP, the project requires 10 hours.

-------------------------------------------

#### 14/Nov/22, 9:00-10:45am

## <center> <u> Chapter 4 </u> </center>
### <center> <u> Measuring Effort for Software Project </u> </center>

#### <u> Featuers of Function Points </u>

1. External Inputs (EI)?
2. External Outputs (EO)?
3. External Inquiries (EQ)?
4. Internal Logical Files (ILF)?

    + External input: the process of element from outside to inside cross boundary by external device such as (sensor, barcode reader) and record into ILF(Internal Logic).

5. External Interface Files (EIF)?

#### <u> 4.2. FP Technique </u>

- You can determine how much effort per FP is required in that particular phase.
- Testing phase is planned for 20 FP of work.
- The project managers
- You can express the cost
- At the end of project, you can find amount of defects.

+ FPs can estimate LOC depends

    LOC = AVC * Number of FP.

    - AVC is an avertage line of code in FP.

    Example = 100FPs, Java
    => LOC = 53 * 100

-------------------------------------------

#### 3/Nov/22, 7:30-9am

## <center> <u> Chapter 4 </u> </center>
### <center> <u> Measuring Effort for Software Project </u> </center>

##### <u> FP Technique </u>

- is direct indicator of the functionality
- The most popular used to estimate the size of SE Project.
- You use to estimate the size of a project.
- The total size is estimated as a single FP value.

##### <u> Disadvantages of Using SLOC </u>

1. LOC depends on experience of programmers.
2. 
3. To count LOC even if we done of coding.

Continue
#### <u> 4.1. SLOC Techinque </u>

Examle:
    - គេប្រាប់ចំនួណ LOC សរុបនៃ system មួយ.
    - គេប្រាប់ផលិតភាពជាមធ្យមនៃ System មួយ
    - គេប្រាប់អត្រាថ្លៃឈ្នួលពលកម្ម
    - ចំនួនមនុស្សជាក់ស្តែងចូលរួមបង្កើត system.

    + Fomular:
    => Cost per LOC = Labor rate / Productivity
    => Total Cost of Project = Cost per LOC * Total number of LOCs
    => Estmated Effort = Total Cost of Project / Labor rate
    => Duration = Effort / People

-------------------------------------------

#### 30/Oct/22, 7:30-9am

## <center> <u> Chapter 4 </u> </center>
### <center> <u> Measuring Effort for Software Project </u> </center>

#### <u> 4.1. SLOC Techinque </u>

- The SLOC technique is an objective method of estimating the size of the project.
- The project size helps determine the resource, effort, cost, and duration of the project.
- Directly calculate the effort to be spend.
- use it when programming langauge and the technology to be predefined.
- This technique includes the calculation of lines of codes, docs of pages, inputs, 
outputs, and component of SW prgram.

##### Counting SLOC:
- The us

    There are many technique that can use to accurately estimate effort, such as:

- Source Lines of Code **(SLOC)**
- Function Point **(FP)**
- Constructive Cost Model **(COCOMO)**
- Delphi 