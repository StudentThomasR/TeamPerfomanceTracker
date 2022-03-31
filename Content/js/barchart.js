var mydata1 = [20, 15, 55, 60, 100];
var ctx1 = document.getElementById('myBarChart1').getContext('2d');
var myChart1 = new Chart(ctx1, {
    type: 'bar',
    data: {
        labels: ['Total Profit', 'Monthly Profit', 'Team Performance', 'Member Performance'],
        datasets: [{
            label: 'Overview',
            data: mydata1,
            backgroundColor: [
                'rgba(186, 217, 98, 0.2)',
                'rgba(255, 159, 64, 0.2)',
                'rgba(75, 192, 192, 0.2)',
                'rgba(255, 99, 132, 0.2)'
            ],
            borderColor: [
                'rgba(186, 217, 98)',
                'rgba(255, 159, 64)',
                'rgba(75, 192, 192)',
                'rgba(255, 99, 132)'
            ],
            borderWidth: 1
        }]
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
                display: true,
                anchor: 'end',
                align: 'top',
                offset: 5
            }
        }
    }
});

var mydata2 = [21, 90, 51, 17, 100];
var ctx2 = document.getElementById('myBarChart2').getContext('2d');
var myChart2 = new Chart(ctx2, {
    type: 'bar',
    data: {
        labels: ['Total Profit', 'Monthly Profit', 'Team Performance', 'Member Performance'],
        datasets: [{
            label: 'Overview',
            data: mydata2,
            backgroundColor: [
                'rgba(186, 217, 98, 0.2)',
                'rgba(255, 159, 64, 0.2)',
                'rgba(75, 192, 192, 0.2)',
                'rgba(255, 99, 132, 0.2)'
            ],
            borderColor: [
                'rgba(186, 217, 98)',
                'rgba(255, 159, 64)',
                'rgba(75, 192, 192)',
                'rgba(255, 99, 132)'
            ],
            borderWidth: 1
        }]
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
                display: true,
                anchor: 'end',
                align: 'top',
                offset: 5
            }
        }
    }
});