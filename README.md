ده مشروع WEB API  فيه تطبيق عملى لل GraphQL 
عباره عن ان أنا بعمل Query  ل Employees And Departments
هنا عاملين ال Employee  و ال Department  كا Records
و الغرض هنا انهم يكونو Records  هو تسهيل العمل مع ال Data أللى بتمثل objects  ثابته يعنى مش هعدل عليها
طيب class  ال employee  هو model  ل API Response  بس ال GraphQL مش بيفهم ده 
فا هنعمل Class هيورث من ObjectGraphType<T> و ده class  من مكتبة GraphQL.NET  اللى عملتلها install 
لما ورثت ال Class ده كده انا عرفته ان ال class  الاساسى بتاعى هيتم استخدامه لانشاء بيانات في ال GraphQL  بناءا على ال EmployeeModel
و في ال Constructor  هعرف ال Fileds  اللى ال GraphQL  هترجعهالى
طيب class ال EmployeeQuery ده اللى انا هستخدمه علشان أعمل ال Query  على الموظفين عن طريق ان انا هورث من Class ال ObjectGraphType  علشان أعرف ال Fileds اللى انا هطلبها من ال GraphQL API
Field<ListGraphType<EmployeeDetailsType>> هنا بعرف Filed هيرجعلى بيانات من نوع EmployeeDetailsType هتتمثل في GraphQL
Name = "Employees" هنا بقوله ان ال Filed ده هيكون اسمه Employees و ده اللى انا هستخدمه في الاستعلام
Resolve ده عباره عن Func بتاخد parameter  واحد و هو ال logic  اللى هيستخدمه في الاستدعاء و هو GetEmployees() اللى عملتلها implementation  في ال EmployeeService
Arguments هنا بحدد معامل لل filed ده و هو ال   Id و اللى من خلاله بعرفه انو هيجيب الموظف اللى ال id  بتاعه بيساوى ال id ده (زى ال where  في ال sql)
Schema  ال Class اللى هيربط ال Query بال Mutations و هيرجعلى ال API
في المثال ده انا مستخدمتش Mutations بس ال Mutations هي اجراء تعديل على ال Data اللى هي عمليات الاضافه و التعديل و الحذف
في المثال ده انا استخدمت Query و ديه بتستخدم علشان اجيب ال Data
Query = serviceProvider.GetRequiredService<EmployeeQuery>();  هنا انا بقولو ان EmployeeQuery هيكون ال Class الرئيسى لل Schema ديه معنى كده ان كل ال Queries  اللى انا عرفتها في ال EmployeeQuery هتكون متاحه في ال GraphQL API 
ال  IserviceProvide هو interface يستخدم للحصول كل ال Service اللى متعرفه في تطبيق ال .NET بعملو inject  في EmployeeDetailsSchema و ببعتو لل base  بتاع ال Schema علشان ال Schema  تقدر توصل لل Services  المطلوبه

