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

function add_dropdown_functionality(func) {
    var icon = func.querySelector('.title-icon-container');
    icon.addEventListener('click', function () {
        var dropdown = func.querySelector('.function-dropdown');
        if (!dropdown.style.maxHeight || dropdown.style.maxHeight == '0px') {
            dropdown.style.maxHeight = dropdown.scrollHeight + 'px';
            icon.querySelector('img').style.transform = 'rotateX(180deg)';
        } else {
            dropdown.style.maxHeight = 0;
            icon.querySelector('img').style.transform = 'rotateX(0deg)';
        }
    });
}
function load_gsc() {
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
                caller = "<p>Called By: " + called_by + "</p>";
            }

            var category = "";
            var gsc_category = element.category;
            if (gsc_category != null) {
                category = "<p>Category: " + gsc_category + "</p>";
            }

            if (optional_parameters) {
                parameters += ", " + optional_parameters;
            }
            
            var game = "";
            var gsc_game = element.game;
            if (gsc_game) {
                game = "<p><b>Game:</b> " + gsc_game + "</p>";
            }

            var client_server = "";
            var gsc_client_server = element.client_or_server;
            if (gsc_client_server) {
                client_server = "<p><b>Client/Server:</b> " + gsc_client_server + "</p>";
            }

            var summary = "";
            var gsc_summary = element.summary;
            if (gsc_summary) {
                summary = "<p><b>Summary:</b> " + gsc_summary + "</p>";
            }

            var example = "";
            var gsc_example = element.example;
            if (gsc_example) {
                example = "<p><b>Example:</b> " + gsc_example + "</p>";
            }

            func.classList.add('gsc-card');
            func.innerHTML = `
                <div class="title-icon-container">
                    <h3 class="function-title">${element.return_type} <b>${element.fuction_name}</b> (${parameters})</h3>
                    <img src="/icons/arrow-down.svg" class="down-arrow-icon" alt="down arrow icon"></img>
                </div>
                <div class="function-dropdown">
                    ${caller}
                    ${category}
                    ${game}
                    ${client_server}
                    ${summary}
                    ${example}
                </div>
                `
            add_dropdown_functionality(func);
            func.name = element.fuction_name;
            func.client_server = element.client_or_server;
            gsc_container.appendChild(func);
        })
    );
}
document.addEventListener('DOMContentLoaded', function() {
    // Run your JavaScript initialization code here
    load_gsc();
    // Simulate JavaScript processing
    setTimeout(function() {
        // Show the body after the first cycle
        document.body.style.visibility = 'visible';
    }, 2000); // Example delay for JavaScript tasks
});

const searchBox = document.getElementById('search-box');

searchBox.addEventListener('input', function() {
    const searchTerm = searchBox.value.toLowerCase();
    const cards = document.querySelectorAll('.gsc-card');
    // const cs_tickbox = document.getElementById('cs_tickbox').checked;  
    cards.forEach(card => {
        const title = card.name.toLowerCase();
        if (title.includes(searchTerm)) {
            card.style.display = 'block';
        } else {
            card.style.display = 'none';
        }
    });
}); 
