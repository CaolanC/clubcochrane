const json_path = '/json/documentation.json';
var gsc_container = document.getElementsByClassName("gsc-documentation-container")[0];

function parameter_formater(parameter_list, format_symbol_left, format_symbol_right) {
    var str = "";
    
    for(var parameter in parameter_list) {
        str += format_symbol_left + parameter + format_symbol_right + ", ";
    }
    var final_str = str.slice(0, -2);
    return final_str;
}

fetch(json_path)
    .then(response => response.json())
    .then(data =>
        Object.values(data).forEach(element => {
            const func = document.createElement('div');
            var parameters = parameter_formater(element.mandatory_parameters, '&lt;', '&gt;');
            var optional_parameters = parameter_formater(element.optional_parameters, '[', ']');

            var caller = "";
            var called_by = element.called_by;
            if (called_by != null) {
                called_by = called_by.replace(/^<+/, '');
                called_by = called_by.replace(/>+$/, '');
                caller = "Called By: " + called_by;
            }

            if (optional_parameters) {
                parameters += ", " + optional_parameters;
            }
            func.classList.add('gsc-card');
            func.innerHTML = `
                <div class="title-icon-container">
                    <h3 class="function-title">${element.return_type} ${element.fuction_name}(${parameters})</h3>
                    <img src="icons/arrow-down.svg" class="down-arrow-icon" alt="down arrow icon"></img>
                </div>
                <div>
                    ${caller}
                </div>
                <p id="function-extra-info"></p>
                `
            gsc_container.appendChild(func);
        })
    );