window.addEventListener("load", () => 
{
    let stepperInput = 
    {
        el:document.querySelector(".stepper-input input"),
        plusBtn:document.querySelector(".stepper-input .input .plus-btn"),
        minusBtn:document.querySelector(".stepper-input .input .minus-btn"),
        list:document.querySelector(".stepper-input .input .list")
    };

    stepperInput.min = parseInt(stepperInput.el.getAttribute("min"));
    stepperInput.max = parseInt(stepperInput.el.getAttribute("max"));
    stepperInput.value = parseInt(stepperInput.el.getAttribute("value"));

    for (let i = stepperInput.min; i <= stepperInput.max; i++) 
    {
        stepperInput.list.innerHTML += `<span>${i}</span>`;
    }
    
    stepperInput.list.style.marginTop = `-${stepperInput.value*80}px`;
    stepperInput.list.style.transition = 'all 300ms ease-in-out';

    stepperInput.minusBtn.addEventListener("click", () =>
    {
        let value = parseInt(stepperInput.el.getAttribute("value"));
        if(value > stepperInput.min)
        {
            value--;
            stepperInput.el.setAttribute("value",value);
            stepperInput.list.style.marginTop = `-${value*80}px`;
        }
    });
       
    stepperInput.plusBtn.addEventListener("click", () =>
    {
        let value = parseInt(stepperInput.el.getAttribute("value"));
        if(value < stepperInput.max)
        {
            value++;
            stepperInput.el.setAttribute("value",value);
            stepperInput.list.style.marginTop = `-${value*80}px`;
        }
    });

});    