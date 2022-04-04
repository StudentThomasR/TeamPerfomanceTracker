var mydata = [20, 15, 55, 100];
var ctx = document.getElementById('myBarChart3').getContext('2d');
var myChart = new Chart(ctx, {
    type: 'bar',
    data: {
        labels: ['Total Profit', 'Monthly Profit', 'Team Performance'],
        datasets: [{
            label: 'Overview',
            data: mydata,
            backgroundColor: [
                'rgba(186, 217, 98, 0.2)',
                'rgba(255, 159, 64, 0.2)',
                'rgba(75, 192, 192, 0.2)'
            ],
            borderColor: [
                'rgba(186, 217, 98)',
                'rgba(255, 159, 64)',
                'rgba(75, 192, 192)'
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