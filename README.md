<div id="top"></div>
<div align="center">
    
[![Contributors][contributors-shield]][contributors-url]
[![MIT License][license-shield]][license-url]
<img src = "https://img.shields.io/github/languages/count/Velin1234/Insurance-risk-assessment?style=for-the-badge">
[![LinkedIn][linkedin-shield]][linkedin-url]

</div>
<!-- PROJECT LOGO -->
<br />
<div align="center">
    <img src="https://github.com/Velin1234/Insurance-risk-assessment/blob/main/InsuranceRiskAssessment/InsuranceRiskAssessment.Web/wwwroot/img/logo.png" alt="Logo" width="120" height="120">

  <h3 align="center">Insurance Risk Assesment</h3>

  <p align="center">
    Разработена дипломна работа с тема "Оценка на застрахователен риск" към ПГЕЕ "К.Фотинов".
  </p>
</div>

<!-- TABLE OF CONTENTS -->
<details>
  <summary>Съдържание</summary>
  <ol>
    <li>
      <a href="#относно-този-проект">Отностно този проект</a>
      <ul>
        <li><a href="#разработено-със">Разработен със</a></li>
      </ul>
    </li>
    <li>
      <a href="#начало">Начало</a>
      <ul>
        <li><a href="#необходим-софтуер">Необходим софтуер</a></li>
        <li><a href="#инсталация">Инсталация</a></li>
      </ul>
    </li>
    <li><a href="#употреба">Употреба</a></li>
    <li><a href="#принос">Принос</a></li>
    <li><a href="#лиценз">Лиценз</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## Относно този проект
Целта на този проект е да улесни работата на работниците в застрахователните агенции. 
Приложението изчислява застрахователния риск на съответния застрахователен случай.
Помага на застрахователя да вземе правилното решение дали си заслужава да застрахова съответното имущество.
<p align="right">(<a href="#top">Обратно нагоре</a>)</p>

### Разработено със

* [HTML](https://developer.mozilla.org/en-US/docs/Web/HTML)
* [CSS](https://developer.mozilla.org/en-US/docs/Web/CSS)
* [ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-6.0)
* [Javascript](https://developer.mozilla.org/en-US/docs/Web/JavaScript)
* [Feather Icons](https://feathericons.com)
<p align="right">(<a href="#top">Обратно нагоре</a>)</p>

<!-- GETTING STARTED -->
## Начало

За да стартирате приложението и придобиете локално копие, следвайте тези прости стъпки.

### Необходим софтуер

* Visual Studio 2022
* .NET Core SDK
* SQL Server

### Инсталация
1. Клонирайте репо-то
```
git clone https://github.com/Velin1234/Insurance-risk-assessment.git
```
2. Отворете .sln файла във Visual Studio 2022
3. Изберете .Web проекта като стартов
4. Отворете Package manager конзолата и напишете
```
update-database
```
5. Пуснете приложението с Ctrl + F5

<!-- USAGE EXAMPLES -->
## Употреба


### Начална страница (Home Page) 

При влизане в приложението ще се озовете в началната страница откъдето можете да се навигирате към Login(вход) и Register(регистрация) страниците, чрез натискане на бутоните в горния десен ъгъл.


![Начална страница pt.1](https://github.com/Velin1234/Insurance-risk-assessment/blob/main/HowToUse-%20Images/HomePage1.png)
![Начална страница pt.2](https://github.com/Velin1234/Insurance-risk-assessment/blob/main/HowToUse-%20Images/HomePage2.png)
![Начална страница pt.3](https://github.com/Velin1234/Insurance-risk-assessment/blob/main/HowToUse-%20Images/HomePage3.png)


### Вход (Login Page)


В Login страницата ще можете да влезете във вашия профил чрез въвеждане на вашия имейл и парола в съответните поленца.
Ако нямате профил , чрез натискане на линк-а "Нямате профил", вие ще бъдете отведен в страница за регистрация.


![Login страница](https://github.com/Velin1234/Insurance-risk-assessment/blob/main/HowToUse-%20Images/LoginPage.png)


### Регистрация (Register Page)


В Register страницата ще можете да регистрирате вашия профил чрез въвеждане на вашия имейл и парола в съответните поленца.


![Register страница](https://github.com/Velin1234/Insurance-risk-assessment/blob/main/HowToUse-%20Images/RegisterPage.png)


### Навигационна страница (Navigation Page)

След успешен вход или регистрация, вие вече ще се намирате в навигационната страница , откъдето можете да се навигирате към избрания от вас вид имущество за който искате да измерите застрахователния риск.


![Навигационна страница](https://github.com/Velin1234/Insurance-risk-assessment/blob/main/HowToUse-%20Images/NavigationPage.png)


### Страница с видове недвижимо имущество (Real Estate Page)

Ако сте избрал да оценявате недвижимо имущество , вие ще бъдете отведен в страницата за избор на вид недвижимо имущество.
При натискане на избрания от вас вид вие ще бъдете отведен в страница с до сегашните ви запазени резултати.


![Страница с видове недвижимо имущество](https://github.com/Velin1234/Insurance-risk-assessment/blob/main/HowToUse-%20Images/RealEstatePage.png)


### Страница с видове движимо имущество (Movable Properties Page)

Ако сте избрал да оценявате движимо имущество , вие ще бъдете отведен в страницата за избор на вид движимо имущество.
При натискане на избрания от вас вид вие ще бъдете отведен в страница с до сегашните ви запазени резултати.


![Страница с видове движимо имущество](https://github.com/Velin1234/Insurance-risk-assessment/blob/main/HowToUse-%20Images/MovablePropertiesPage.png)


### Страница с резултати (Results Page)

След като сте избрали видът на имуществото , вие бивате отведен в страница с всички текущи резултати за даденото имущество.
Ако искате да изчислите риска за ново имущество , при натискане на плюса в горния десен ъгъл , вие бивате навигиран в страница за изчисление и запазване на резултат.


![Страница с резултати](https://github.com/Velin1234/Insurance-risk-assessment/blob/main/HowToUse-%20Images/ResultsPage.png)


### Страница за изчисление и запазване на резултат (Create Result Page)

При въвеждане на необходимите данни можете да видите резултата си до момента при натискане на бутон „Покажи резултат“ и да запазите резултата си с натискане на бутон "Запази резултат". След като сте го запазили , той ще бъде визуализиран в страницата с резултати.


![Страница за изчисление и запазване на резултат](https://github.com/Velin1234/Insurance-risk-assessment/blob/main/HowToUse-%20Images/CreatePage.png)
![Страница за изчисление и запазване на резултат(Попълнена)](https://github.com/Velin1234/Insurance-risk-assessment/blob/main/HowToUse-%20Images/CreatePageResult.png)
![Страница с резултати след въвеждане на резултат](https://github.com/Velin1234/Insurance-risk-assessment/blob/main/HowToUse-%20Images/ResultsPageAfterCreation.png)


### Страница с детайли (Details Page)

Ако искате да видите детайлите за въведеното имущество , при натискане на бялата плочица за самото имущество , вие бивате отведен към страница с
детайлите на имуществото.
Ако потребителя иска да промени данните за имуществото при натискане на иконката долу в дясно той бива отведен в страница за промяна на данните.


![Страница с детайли](https://github.com/Velin1234/Insurance-risk-assessment/blob/main/HowToUse-%20Images/DetailsPage.png)


### Страница за промяна на резултат (Edit Page)


![Страница за промяна на резултат](https://github.com/Velin1234/Insurance-risk-assessment/blob/main/HowToUse-%20Images/EditPage.png)


### Страница за изтриване (Delete Page)


Ако искате да изтриете резултат за дадено имущество , вие можете да го направите с натискане на иконката за кошче , намираща се върху бялата плочица в страницата с резултати.


![Страница за промяна на резултат](https://github.com/Velin1234/Insurance-risk-assessment/blob/main/HowToUse-%20Images/DeletePage.png)


_За повече информация се обърнете към [Документацията](https://github.com/Velin1234/Insurance-risk-assessment/blob/BetterReadMe/Insurance%20Risk%20Assesment%2012%D0%B1.pdf)_

<p align="right">(<a href="#top">Обратно нагоре</a>)</p>

<!-- CONTRIBUTING -->
## Принос

Приносът е това, което прави общността с отворен код толкова невероятно място за учене, вдъхновение и създаване. Всички ваши приноси са **много оценени**.

Ако имате предложение, което би направило приложението по-добро, моля, разклонете репото и създайте pull request. Можете също така просто да отворите issue с етикет "enhancement".

1. Fork-нете този проект
2. Създайте вашия feature branch (`git checkout -b feature/AmazingFeature`)
3. Запазете промените си (`git commit -m 'Add some AmazingFeature'`)
4. Push-нете към Branch-а (`git push origin feature/AmazingFeature`)
5. Отворете Pull Request

<p align="right">(<a href="#top">Обратно нагоре</a>)</p>

<!-- LICENSE -->
## Лиценз

Разработено под MIT Лиценз. Вижте `LICENSE.txt` за повече информация.

<p align="right">(<a href="#top">Обратно нагоре</a>)</p>

<!-- MARKDOWN LINKS & IMAGES -->

[contributors-shield]: https://img.shields.io/github/contributors/Velin1234/Insurance-risk-assessment.svg?style=for-the-badge
[contributors-url]: https://github.com/Velin1234/Insurance-risk-assessment/graphs/contributors
[license-shield]: https://img.shields.io/github/license/Velin1234/Insurance-risk-assessment.svg?style=for-the-badge
[license-url]: https://github.com/Velin1234/Insurance-risk-assessment/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/in/velin-kurtev-b0821b1b9/
