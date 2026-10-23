 window.onload = function () {

    document.getElementById('puckLoadingVideo').play();  

    // When the user scrolls the page, execute myFunction
    window.onscroll = function () { myFunction(); };

    // Get the header
    var header = document.getElementById("header");

    // Get the offset position of the navbar
    var sticky = header.offsetTop;

    // Add the sticky class to the header when you reach its scroll position. Remove "sticky" when you leave the scroll position
    function myFunction() {

        if (window.pageYOffset > sticky) {
            header.classList.add("sticky");
        } else {
            header.classList.remove("sticky");
        }
    }

    document.getElementById("playerByTeamSeasonDiv").style.display = 'none';
    document.getElementById("seasonTeamGamesDiv").style.display = 'none';
    document.getElementById("currentTeamsTableDiv").style.display = 'none';             
        
    let anchorlinks = document.querySelectorAll('a[href^="#"]');

    for (let item of anchorlinks) {
            
        item.addEventListener('click', (e) => {
            let hashval = item.getAttribute('href');
            let target = document.querySelector(hashval);
            target.scrollIntoView({
                behavior: 'smooth',
                block: 'start'
            });
            history.pushState(null, null, hashval);
            e.preventDefault();
        });
     }          

    SetDatePickers();
    
    document.getElementById("teamsLink").onclick = function () {

        document.getElementById("playerByTeamSeasonDiv").style.display = 'none';
        document.getElementById("seasonTeamGamesDiv").style.display = 'none';

        if (document.getElementById("teamOption").firstChild.innerHTML == "") {
            GetCurrentTeams(MyAppUrlSettings.teamDataAppUrl).then(function (response) {

                //console.log("Success!", response);               

                let teamsObj = JSON.parse(response);
                let teamLinksTableString = ReturnTeamLogoTableString(teamsObj["Teams"]);

                document.getElementById("currentTeamsTableDiv").innerHTML = teamLinksTableString;

                // Create and append select list
                var selectList = document.createElement("select");
                selectList.id = "seasonSelect";

                // Create and append the "Select" options
                //for (var i = 0; i < array.length; i++) {
                var option = document.createElement("option");
                option.value = 0;
                option.text = "Select a season...";
                selectList.appendChild(option);
                selectList.addEventListener('change', function (data) {
                    //alert('changed');

                    var teamLogoImageLinks = document.getElementsByClassName("teamLogoImageLink");
                    for (var link in teamLogoImageLinks) {
                        if (teamLogoImageLinks[link].href.indexOf("season") == -1)
                            teamLogoImageLinks[link].href = teamLogoImageLinks[link].href.concat("&season=" + selectList.options[selectList.selectedIndex].value);
                        else {
                            var seasonEqualCharPos = teamLogoImageLinks[link].href.lastIndexOf("=");
                            teamLogoImageLinks[link].href = teamLogoImageLinks[link].href.substring(0, seasonEqualCharPos).concat("=" + selectList.options[selectList.selectedIndex].value);
                        }
                    }

                });
                //}

                var label = document.createElement("label");
                label.innerHTML = "Pick a season:";
                label.htmlFor = "seasonSelect";
                label.className = "teamSearchLabels";

                document.getElementById("currentTeamsTableDiv").prepend(selectList);
                document.getElementById("currentTeamsTableDiv").prepend(label);

            }, function (error) {
                //console.error("Failed!", error);
            }).then(function (response) {
                let seasonsDD = document.getElementById("seasonSelect");
                FillSeasonDropDown(seasonsDD);
            });           

        }
        document.getElementById("currentTeamsTableDiv").style.display = 'block';       

        return false;
    };

    document.getElementById("gamesLink").onclick = function () {

        document.getElementById("playerByTeamSeasonDiv").style.display = 'none';
        document.getElementById("currentTeamsTableDiv").style.display = 'none';

        
        let teamsDD = document.getElementById("teamSelection");
        FillTeamDropDown(teamsDD);
        document.getElementById("seasonTeamGamesDiv").style.display = 'block';

        return false;
    };

    document.getElementById("gameSubmit").onclick = function () {

        GameStatSearchSubmit();        
        return false;
    };

    document.getElementById("playersLink").onclick = function () {

        document.getElementById("currentTeamsTableDiv").style.display = 'none';
        document.getElementById("seasonTeamGamesDiv").style.display = 'none';              

        let teamsDD = document.getElementById("playerTeamSelection");
        FillTeamDropDown(teamsDD);               
        
        let seasonsDD = document.getElementById("seasonSelection");
        FillSeasonDropDown(seasonsDD);
        document.getElementById("playerByTeamSeasonDiv").style.display = 'block';
        return false;
    };

    document.getElementById("playerSubmit").onclick = function () {

        PlayerStatSearchSubmit();
        return false;
    };

    if (selectionOption !== null && selectionOption !== "") {

        if (selectionOption == "#playerOption") {
            document.getElementById("playersLink").click();
        }
        else if (selectionOption == "#gameOption") {
            document.getElementById("gamesLink").click();
        }
        else if (selectionOption == "#teamOption") {
            document.getElementById("teamsLink").click();
        }

        let target = document.querySelector(selectionOption);
        target.scrollIntoView({
            behavior: 'smooth',
            block: 'start'
        });
        history.pushState(null, null, selectionOption);
    }
    
};



    

  

    
        