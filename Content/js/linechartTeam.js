var team1 = [50, 55, 62, 78, 53, 25]
var team2 = [30, 34, 44, 36, 15, 28]
var team3 = [80, 84, 94, 62, 70, 75]
var team4 = [10, 29, 15, 37, 45, 50]
var team5 = [90, 60, 68, 90, 86, 95]

var ctx = document.getElementById('myLineChartTeam').getContext('2d');
var myChart = new Chart(ctx, {
    type: 'line',
    data: {
        labels: ['March', 'April', 'May', 'June', 'July', 'August'],
        datasets: [
            {
                label: 'Team 1',
                data: team1,
                borderColor: "rgb(75, 192, 192)",
                fill: false,
                tension: 0.3
            },

            {
                label: 'Team 2',
                data: team2,
                borderColor: "rgba(206, 29, 29, 1)",
                fill: false,
                tension: 0.3
            },

            {
                label: 'Team 3',
                data: team3,
                borderColor: "rgba(201, 204, 54, 1)",
                fill: false,
                tension: 0.3
            },

            {
                label: 'Team 4',
                data: team4,
                borderColor: "rgba(26, 176, 59, 1)",
                fill: false,
                tension: 0.3
            },

            {
                label: 'Team 5',
                data: team5,
                borderColor: "rgba(0, 0, 0, 1)",
                fill: false,
                tension: 0.3
            }
        ]
    },

    options: {
        responsive: true,
        maintainAspectRatio: false,

        scales: {
            yAxes: [{
                ticks: {
                    beginAtZero: true,
                    suggestedMax: 30
                }
            }]
        },
        plugins: {
            datalabels: {
                display: false,
                anchor: 'end',
                align: 'top',
                offset: 5
            }
        }
    }
});