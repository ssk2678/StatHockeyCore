var rowSize = 4;

function SetDatePickers() {

    const pickerFrom = datepicker(document.querySelector("#gamesFromDate"), { id: 1, position: 'bl' });
    const pickerTo = datepicker(document.querySelector("#gamesToDate"), { id: 1, position: 'bl' });

}

function PlayerStatSearchSubmit() {

    var playerTeamSelectionDD = document.getElementById("playerTeamSelection");
    var playerTeamId = playerTeamSelectionDD.value;
    var playerTeamName = playerTeamSelectionDD.options[playerTeamSelectionDD.selectedIndex].text;

    var seasonSelectionDD = document.getElementById("seasonSelection");
    var seasonId = seasonSelectionDD.value;
    var seasonValue = seasonSelectionDD.options[seasonSelectionDD.selectedIndex].text;

    let formIsValid = ValidatePlayersForm();

    if (formIsValid) {
        var url = MyAppUrlSettings.teamPlayersDataAppUrl + "?teamId=" + playerTeamId + "&seasonId=" + seasonId;
        document.querySelector('#playersPopupLoader').style.display = 'block';
        GetTeamSeasonRoster(url).then(function (response) {
            document.querySelector('#playersPopupLoader').style.display = 'none';
            let teamSeasonRosterObj = JSON.parse(response);
            let teamSeasonRoster = teamSeasonRosterObj.Roster;

            var teamSeasonRosterTableHtmlString = ReturnTeamSeasonRosterTable(teamSeasonRoster, seasonId);
            document.getElementById("teamSeasonRosterTableDiv").innerHTML = teamSeasonRosterTableHtmlString;

        }, function (error) {

        });
    }
}

function GameStatSearchSubmit() {

    var teamSelectionDD = document.getElementById("teamSelection");

    var teamId = teamSelectionDD.value;
    var teamName = teamSelectionDD.options[teamSelectionDD.selectedIndex].text;
    var startDate = document.getElementById("gamesFromDate").value;
    var endDate = document.getElementById("gamesToDate").value;

    var formIsValid = ValidateGamesForm();

    if (formIsValid) {
        var url = MyAppUrlSettings.gameDataAppUrl + "?teamId=" + teamId + "&teamName=" + teamName + "&startDate=" + startDate + "&endDate=" + endDate;

        // Get the modal
        var teamGamesModal = document.getElementById("teamGameModal");
        // Get the <span> element that closes the modal
        var teamGameModalCloseSpan = document.getElementsByClassName("teamGamesClose")[0];
        // When the user clicks on <span> (x), close the modal
        teamGameModalCloseSpan.onclick = function () {
            teamGamesModal.style.display = "none";
        };
        // When the user clicks anywhere outside of the modal, close it
        window.onclick = function (event) {

            if (event.target == teamGamesModal) {
                teamGamesModal.style.display = "none";
            }

        };
        document.querySelector('#gamesPopupLoader').style.display = 'block';
        GetTeamGames(url).then(function (response) {
            document.querySelector('#gamesPopupLoader').style.display = 'none';
            let teamScheduleObj = JSON.parse(response);
            let teamScheduleData = teamScheduleObj.Dates;

            //populate popup div header with team name and logo
            document.getElementsByClassName("teamGamesModalBody")[0].childNodes[3].src = teamScheduleObj.SelectedTeamLogoPath;
            document.getElementsByClassName("teamGamesModalHeader")[0].childNodes[3].innerHTML = teamName;
            document.getElementsByClassName("teamGamesModalFooter")[0].childNodes[1].innerHTML = "Games From " + startDate + " To " + endDate;

            // When the user clicks on the button, open the modal
            teamGamesModal.style.display = "block";

            var gameTableHTMLString = ReturnTeamGamesTable(teamScheduleData);
            document.getElementsByClassName("teamGamesModalBody")[0].childNodes[1].innerHTML = gameTableHTMLString;


        }, function (error) {
            //console.error("Failed!", error);
        });
    }
    //return false;
}

function FillSeasonDropDown(seasonsDD) {
    if (seasonsDD.options.length == 1) {
        GetAllSeasons(MyAppUrlSettings.seasonDataAppUrl).then(function (response) {
            let seasonsObj = JSON.parse(response);
            let seasonsData = seasonsObj["Seasons"];

            for (var i = 0; i < seasonsData.length; i++) {

                let opt = document.createElement('option');
                seasonValue = seasonsData[i].SeasonId;
                opt.appendChild(document.createTextNode(seasonValue.slice(0, 4) + "-" + seasonValue.slice(4)));
                opt.value = seasonsData[i].SeasonId;

                seasonsDD.appendChild(opt);

            }
        });
    }
}

function GetTeamGames(gamesUrl) {

    return GetData(gamesUrl);
}

function GetTeamSeasonRoster(rosterUrl) {
    return GetData(rosterUrl);
}

function FillTeamDropDown(teamsDD) {
    
    if (teamsDD.options.length == 1) {
        GetCurrentTeams(MyAppUrlSettings.teamDataAppUrl).then(function (response) {
            //console.log("Success!", response);
            let teamsObj = JSON.parse(response);
            let teamsData = teamsObj["Teams"];

            for (var i = 0; i < teamsData.length; i++) {

                var opt = document.createElement('option');
                opt.appendChild(document.createTextNode(teamsData[i].Name));
                opt.value = teamsData[i].Id;

                teamsDD.appendChild(opt);
            }

        }, function (error) {
            //console.error("Failed!", error);
        });
    }
}

function GetCurrentTeams(teamsUrl) {

    return GetData(teamsUrl);
}

function GetAllSeasons(seasonsUrl) {

    return GetData(seasonsUrl);
}

function GetData(url) {

    // Return a new promise
    return new Promise(function (resolve, reject) {
        // Do the usual XHR stuff
        var req = new XMLHttpRequest();
        req.open('GET', url);
        req.onload = function () {
            // This is called even on 404 etc
            // so check the status
            if (req.status == 200) {
                //Resolve the promise with the response text
                resolve(req.response);
            }
            else {
                // Otherwise reject with the status text
                // which will hopefully be a meaningful error
                reject(Error(req.statusText));
            }
        }

        // Handle network errors
        req.onerror = function () {
            reject(Error("Network Error"));
        }

        // Make the request
        req.send();

    });

}

function ReturnTeamLogoTableString(teamsData) {

    var teamLinksTableLogoIconString = "<table id=\"currentTeamLogos\">";
    var tableRowData = [];
    var teamLinksRowString;

    for (var i = 0; i < teamsData.length; i++) {

        if (i > 0 && i % rowSize == 0) {

            teamLinksRowString = ReturnTeamLogoTableRow(tableRowData);
            teamLinksTableLogoIconString += teamLinksRowString;
            tableRowData = [];
        }

        tableRowData.push(teamsData[i]);
    }

    teamLinksRowString = "";

    if (tableRowData.length > 0) {

        teamLinksRowString = ReturnTeamLogoTableRow(tableRowData);
        teamLinksTableLogoIconString += teamLinksRowString;
        tableRowData = [];
    }

    teamLinksTableLogoIconString += "</table>";
    return teamLinksTableLogoIconString;
}

function ReturnTeamLogoTableRow(trData) {

    var teamLinksRowLogoIconString = "<tr>";
    var teamLinksCellString;

    for (let i = 0; i < trData.length; i++) {

        teamLinksCellString = ReturnTeamLogoTableCell(trData[i].LogoPath, trData[i].Name, trData[i].Id);
        teamLinksRowLogoIconString += teamLinksCellString;
    }

    if (trData.length < rowSize) {

        for (let i = 0; i <= (rowSize - trData.length); i++) {
            ReturnTeamLogoTableCell(trData[i].LogoPath, trData[i].Name);
        }
    }

    teamLinksRowLogoIconString += "</tr>";
    return teamLinksRowLogoIconString;
}

function ReturnTeamLogoTableCell(teamLogoPath, teamName, teamId) {

    var teamLinksCellLogoIconString = "<td>";
    

    //if (teamLogoPath = "") {

    //}

    teamLinksCellLogoIconString += teamLogoPath == "" ? "" : "<ul>" + "<li class=" + "\"teamLogoTableListItem\"" + ">" + "<a href='" + MyAppUrlSettings.teamDetailAppUrl + "?teamId=" + teamId + "'" + "class=\"teamLogoImageLink\"" + ">" + "<img src=" + "\"" + teamLogoPath + "\"" + "class=\"teamLogoImage\"" + "/></a></li>" + "<li class=\"teamLogoTableListItem\"" + "><a href='" + MyAppUrlSettings.teamDetailAppUrl + "?teamId=" + teamId + "'>" + teamName + "</a></li>" + "</ul>"//"<a href=\"#\">" + "<img src=" + "\"" + teamLogoPath + "\"" + "/>" + teamName + "</a>";
    teamLinksCellLogoIconString += "</td>";

    return teamLinksCellLogoIconString;
}

function ReturnTeamGamesTable(gameDates) {

    var teamGamesTable = "<table id=\"teamGamesTable\">" + ReturnTeamGameRow(null, true);

    teamGamesTable += "<tbody>";

    for (var i = 0; i < gameDates.length; i++) {
        teamGamesTable += ReturnTeamGameRow(gameDates[i].Games[0], false);
    }

    teamGamesTable += "</tbody></table>";

    return teamGamesTable;
}

function ReturnTeamGameRow(gameRow, isheader) {

    if (isheader) {
        return "<thead><tr><th>Date</th><th>Season</th><th>Home</th><th>Away</th><th>Game Data</th></tr></thead>";
    }
    else {

        var gameTableRow = "<tr>";

        var gameDateCell = ReturnTeamGameDataRowCell(moment.utc(gameRow.GameDate).format('MM/DD/YYYY'));
        var gameSeasonCell = ReturnTeamGameDataRowCell(gameRow.Season.slice(0, 4) + "-" + gameRow.Season.slice(4));
        var gameAwayTeamNameCell = ReturnTeamGameDataRowCell(gameRow.Teams.Away.Team.Name);
        var gameHomeTeamNameCell = ReturnTeamGameDataRowCell(gameRow.Teams.Home.Team.Name);
        var gameLinkCell = ReturnTeamGameDataRowCell(gameRow.GamePk);

        gameTableRow += gameDateCell + gameSeasonCell + gameAwayTeamNameCell + gameHomeTeamNameCell + gameLinkCell + "</tr>";

        //var gameVenue = gameRow.venue.name;
        return gameTableRow;
    }
}

function ReturnTeamGameDataRowCell(data) {
    return "<td>" + data + "</td>";
} 

function ReturnTeamSeasonRosterTable(teamSeasonRosterData, seasonId) {
    if (teamSeasonRosterData != null) {
        var teamSeasonRosterTable = "<table id=\"teamSeasonPlayersTable\" class=\"teamSeasonPlayersTable\">" + ReturnTeamPlayerRow(null, true, seasonId);

        teamSeasonRosterTable += "<tbody>";

        for (var i = 0; i < teamSeasonRosterData.length; i++) {

            teamSeasonRosterTable += ReturnTeamPlayerRow(teamSeasonRosterData[i], false, seasonId);
        }

        teamSeasonRosterTable += "</tbody></table>";
    }
    else {
        teamSeasonRosterTable = "";
    }

    return teamSeasonRosterTable;
}

function ReturnTeamPlayerRow(playerRow, isheader, seasonId) {

    if (isheader) {
        return "<thead><tr><th>Full Name</th><th>Position</th><th>Jersey Number</th><th>Player Data</th></tr></thead>";
    }
    else {
        var teamPlayerRow = "<tr>";

        var playerFullNameCell = ReturnTeamPlayerDataCell(playerRow.Person.FullName);
        var playerPositionCell = ReturnTeamPlayerDataCell(playerRow.Position.Type);
        var playerJerseyNumberCell = ReturnTeamPlayerDataCell(playerRow.JerseyNumber);
        var playerLinkCell = ReturnTeamPlayerDataLinkCell(playerRow.Person.Id, seasonId);

        teamPlayerRow = playerFullNameCell + playerPositionCell + playerJerseyNumberCell + playerLinkCell + "</tr>";

        return teamPlayerRow;
    }
}

function ReturnTeamPlayerDataCell(data) {

    return "<td>" + data + "</td>";//"<td>" + "<a href=\"" + data + "\"<img src=\"" + "\"/></a>" + "</td>";
}

function ReturnTeamPlayerDataLinkCell(data, seasonId) {

    return "<td>" + "<a href='" + MyAppUrlSettings.playerDetailAppUrl + "?playerId=" + data + "&seasonId=" + seasonId + "'>" + "<img src=\"" + "../images/player.png\"" + " class=\"" + "playerIcon" + "\"" + "\"/>" + "</a>" + "</td>";
}

function ValidatePlayersForm() {

    let teamSelectionValue = document.getElementById("playerTeamSelection").value;
    var seasonSelectionValue = document.getElementById("seasonSelection").value;

    let isValid = true;

    // Validate Entries
    if (teamSelectionValue == "") {
        document.getElementById("playerSearchTeamSelectionError").firstChild.nodeValue = "This field is required.";
        isValid = false;
    }
    else {
        document.getElementById("playerSearchTeamSelectionError").firstChild.nodeValue = "";
    }

    if (seasonSelectionValue == "") {
        document.getElementById("seasonPickerError").firstChild.nodeValue = "This field is required";
        isValid = false;
    }
    else {
        document.getElementById("seasonPickerError").firstChild.nodeValue = "";
    }

    return isValid;
}

function ValidateGamesForm() {

    let teamSelectionValue = document.getElementById("teamSelection").value;
    var fromDateField = document.getElementById("gamesFromDate").value;
    var toDateField = document.getElementById("gamesToDate").value;

    let isValid = true;

    // Validate Entries
    if (teamSelectionValue == "") {
        document.getElementById("gameSearchTeamSelectionError").firstChild.nodeValue = "This field is required.";
        isValid = false;
    }
    else {
        document.getElementById("gameSearchTeamSelectionError").firstChild.nodeValue = "";
    }

    if (fromDateField == "") {
        document.getElementById("dateFromError").firstChild.nodeValue = "This field is required.";
        isValid = false;
    }
    else {
        document.getElementById("dateFromError").firstChild.nodeValue = "";
    }

    if (toDateField == "") {
        document.getElementById("dateToError").firstChild.nodeValue = "This field is required.";
        isValid = false;
    }
    else {
        document.getElementById("dateToError").firstChild.nodeValue = "";
    }

    return isValid;
}

