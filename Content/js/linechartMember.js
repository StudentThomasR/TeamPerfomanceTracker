var member1 = [50, 55, 62, 78, 53, 25]
var member2 = [30, 34, 44, 36, 15, 28]
var member3 = [80, 84, 94, 62, 70, 75]
var member4 = [10, 29, 15, 37, 45, 50]
var member5 = [90, 60, 68, 90, 86, 95]

var ctx = document.getElementById('myLineChartMember').getContext('2d');
var myChart = new Chart(ctx, {
    type: 'line',
    data: {
        labels: ['March', 'April', 'May', 'June', 'July', 'August'],
        datasets: [
            {
                label: 'Member 1',
                data: member1,
                borderColor: "rgb(75, 192, 192)",
                fill: false,
                tension: 0.3
            },

            {
                label: 'Member 2',
                data: member2,
                borderColor: "rgba(206, 29, 29, 1)",
                fill: false,
                tension: 0.3
            },

            {
                label: 'Member 3',
                data: member3,
                borderColor: "rgba(201, 204, 54, 1)",
                fill: false,
                tension: 0.3
            },

            {
                label: 'Member 4',
                data: member4,
                borderColor: "rgba(26, 176, 59, 1)",
                fill: false,
                tension: 0.3
            },

            {
                label: 'Member 5',
                data: member5,
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