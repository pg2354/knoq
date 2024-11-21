function changeStep(stepId) {
    const steps = document.querySelectorAll('.step');
    steps.forEach(step => {
        if (step.id === stepId) {
            step.classList.add('active');
        } else {
            step.classList.remove('active');
        }
    });
}
const option2 = document.getElementById('option2');
const option1 = document.getElementById('option1');
  const reasonInput = document.querySelector('.reason-input');

  option2.addEventListener('change', function() {
    if (this.checked) {
      reasonInput.style.display = 'block';
    }
  });
  option1.addEventListener('change', function() {
    if (this.checked) {
      reasonInput.style.display = 'none';
    }
  });