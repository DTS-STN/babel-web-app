using System.Collections.Generic;

namespace babel_web_app.Lib.Language
{
    public class LanguageBit {
        public string English { get; set; }
        public string French { get; set; }
        public LanguageBit(string english, string french) {
            English = english;
            French = french;
        }
    }
    public class Translator
    {
        private readonly string _language;
        public Translator(string language) {
            _language = language;
        }

        //public string MY_THING => Get("my_thing");

        private readonly Dictionary<string, LanguageBit> Dict = new Dictionary<string, LanguageBit> {
            {
                "new_simulation",
                new LanguageBit(
                    "New Simulation", 
                    "Nouvelle Simulation"
                )
            },
            {
                "admin_title",
                new LanguageBit(
                    "Admin", 
                    "Admin"
                )
            },
            {
                "name_column",
                new LanguageBit(
                    "Name", 
                    "Nom"
                )
            },
            {
                "title",
                new LanguageBit(
                    "Policy Difference Engine", 
                    "Moteur de différence de politique"
                )
            },
            {
                "info",
                new LanguageBit(
                    "The Policy Difference Engine (PDE) is a project led by Service Canada. It is a tool that forecasts the impact of a possible policy change on the people who use our services. It encourages both quantitative and qualitative policy design processes. Concretely, the Policy Difference Engine uses code created from policy rules to create simulated populations.",
                    "Le moteur de différence de politique (MDP) est un projet dirigé par Service Canada. C'est un outil qui prévoit l'impact d'un changement de politique possible sur les gens qui utilisent le service. Il soutient les processus de conception de politiques tant qualitatifs que quantitatifs. De façon concrète, le moteur de différence politique utilise le code créé à partir des règles de politique pour créer des populations simulées."
                )
            },
            {
                "test_title",
                new LanguageBit(
                    "Test the Policy Difference Engine",
                    "Tester le moteur de différence politique"
                )
            },
            {
                "test_info1",
                new LanguageBit(
                    "In this scenario, you are a social development policy analyst. You have been asked to provide data for a future policy discussion on maternity benefits entitlement.",
                    "Dans cette simulation, vous êtes un analyste des politiques de développement social. On vous a demandé de fournir des données pour une discussion à venir sur la politique concernant le droit aux prestations de maternité. "
                )
            },
            {
                "test_info2",
                new LanguageBit(
                    "Using the Policy Difference Engine, you can apply possible changes to a fictitious population and determine who might be affected and how. Remember, this is just a simulation. The people are not real and nor is the change in policy.",
                    "À l'aide du moteur de différences de politique, vous pouvez appliquer des changements possibles à une population fictive, et déterminer qui pourrait être affecté et comment. N'oubliez pas qu'il ne s'agit que d'une simulation. Les gens et le changement de politique ne sont pas réels."
                )
            },
            {
                "test_button_text",
                new LanguageBit(
                    "Get Started",
                    "Essayer"
                )
            },
            /*** NEW SIMULATION ***/
            {
                "form_title",
                new LanguageBit(
                    "Propose a policy adjustment",
                    "Propose a policy adjustment"
                )
            },
            {
                "form_info",
                new LanguageBit(
                    "These variables are extracted from maternity policies embedded within the IE (Imaginary Employment) Act. Change these variables and run a simulation to see the potential impacts. Please note that this is mock data of 100 imaginary individuals from an entirely fictional place.",
                    "These variables are extracted from maternity policies embedded within the IE (Imaginary Employment) Act. Change these variables and run a simulation to see the potential impacts. Please note that this is mock data of 100 imaginary individuals from an entirely fictional place."
                )
            },
            {
                "reset_fields_button",
                new LanguageBit(
                    "Reset Fields",
                    "Reset Fields"
                )
            },
            {
                "run_simulation_text",
                new LanguageBit(
                    "Run Simulation",
                    "Run my Simulation"
                )
            },
            {
                "num_weeks_description",
                new LanguageBit(
                    "Number of Weeks for which an applicant can claim benefits",
                    "Number of Weeks for which an applicant can claim benefits"
                )
            },

            /*** RESULTS ***/
                        {
                "simulation_results_title",
                new LanguageBit(
                    "Simulation Results", 
                    "Résultats de la simulation"
                )
            },
            {
                "simulation_results_info",
                new LanguageBit(
                    "You changed some variables, and we created a simulated population of 100 individuals using mock data to show you who might be impacted by your changes. Try exploring the data here, or download for the tool of your choice.", 
                    "Misssing..."
                )
            },
            {
                "your_changes_title",
                new LanguageBit(
                    "Your Changes",
                    "Your Changes"
                )
            },
            {
                "original_value_header",
                new LanguageBit(
                    "Original Value",
                    "Valeurs initiales"
                )
            },
            {
                "proposed_change_header",
                new LanguageBit(
                    "Proposed Change",
                    "Changement proposé"
                )
            },
            {
                "max_weekly_amount_label",
                new LanguageBit(
                    "Maximum Weekly Amount",
                    "Montant hebdomadaire maximum"
                )
            },
            {
                "percentage_label",
                new LanguageBit(
                    "Percentage of Average Income",
                    "Pourcentage de revenu moyen"
                )
            },
            {
                "num_weeks_label",
                new LanguageBit(
                    "Number of Eligible Weeks",
                    "Nombre de semaines d'admissibilité"
                )
            },
            {
                "overall_results_title",
                new LanguageBit(
                    "Overall Results",
                    "Overall Results"
                )
            },
            {
                "sample_size_label",
                new LanguageBit(
                    "Sample Size",
                    "Sample Size"
                )
            },
            {
                "percent_cost_change_label",
                new LanguageBit(
                    "Percent Change in Cost",
                    "Percent Change in Cost"
                )
            },
            {
                "avg_change_label",
                new LanguageBit(
                    "Average Entitlement Change",
                    "Average Entitlement Change"
                )
            },
            {
                "avg_percent_change_label",
                new LanguageBit(
                    "Average Percent Change",
                    "Average Percent Change"
                )
            },
            {
                "gainers_title",
                new LanguageBit(
                    "People Who Gained Money",
                    "Gens ayant gagné de l'argent"
                )
            },
            {
                "percent_gainers_label",
                new LanguageBit(
                    "Percent of Sample that Gained Money",
                    "Percent of Sample that Gained Money"
                )
            },
            {
                "avg_gain_label",
                new LanguageBit(
                    "Average Entitlement Gain",
                    "Average Entitlement Gain"
                )
            },
            {
                "avg_percent_gain_label",
                new LanguageBit(
                    "Average Percent Gain",
                    "Average Percent Gain"
                )
            },
            {
                "losers_title",
                new LanguageBit(
                    "People Who Lost Money",
                    "Gens ayant perdu de l'argent"
                )
            },
            {
                "percent_losers_label",
                new LanguageBit(
                    "Percent of Sample that Lost Money",
                    "Percent of Sample that Lost Money"
                )
            },
            {
                "avg_loss_label",
                new LanguageBit(
                    "Average Entitlement Lost",
                    "Average Entitlement Lost"
                )
            },
            {
                "avg_percent_loss_label",
                new LanguageBit(
                    "Average Percent Lost",
                    "Average Percent Lost"
                )
            },
            {
                "agg_group_header",
                new LanguageBit(
                    "Group",
                    "Group"
                )
            },
            {
                "agg_sample_size_header",
                new LanguageBit(
                    "Sample Size",
                    "Sample Size"
                )
            },
            {
                "agg_sample_percent_header",
                new LanguageBit(
                    "Sample Percent",
                    "Sample Percent"
                )
            },
            {
                "agg_avg_change_header",
                new LanguageBit(
                    "Average Entitlement Change",
                    "Average Entitlement Change"
                )
            },
            {
                "agg_avg_percent_change_header",
                new LanguageBit(
                    "Average Percent Change",
                    "Average Percent Change"
                )
            },
            {
                "agg_percent_gained_header",
                new LanguageBit(
                    "Percent that Gained",
                    "Percent that Gained"
                )
            },
            {
                "agg_percent_lost_header",
                new LanguageBit(
                    "Percent that Lost",
                    "Percent that Lost"
                )
            },
            {
                "agg_percent_unchanged_header",
                new LanguageBit(
                    "Percent Unchanged",
                    "Percent Unchanged"
                )
            },
            {
                "agg_aggregation_by_title",
                new LanguageBit(
                    "Aggregation By",
                    "Aggregation By"
                )
            },
            /*** Aggregation Keys ***/
            {
                "Province",
                new LanguageBit(
                    "Province",
                    "Province"
                )
            },
            {
                "Age",
                new LanguageBit(
                    "Age",
                    "Age"
                )
            },
            {
                "Education",
                new LanguageBit(
                    "Education",
                    "Education"
                )
            },
            {
                "Income",
                new LanguageBit(
                    "Income",
                    "Income"
                )
            },
            /*** Provinces ***/
            {
                "British Columbia",
                new LanguageBit(
                    "British Columbia",
                    "British Columbia"
                )
            },
            {
                "Alberta",
                new LanguageBit(
                    "Alberta",
                    "Alberta"
                )
            },
            {
                "Saskatchewan",
                new LanguageBit(
                    "Saskatchewan",
                    "Saskatchewan"
                )
            },
            {
                "Manitoba",
                new LanguageBit(
                    "Manitoba",
                    "Manitoba"
                )
            },
            {
                "Ontario",
                new LanguageBit(
                    "Ontario",
                    "Ontario"
                )
            },
            {
                "Quebec",
                new LanguageBit(
                    "Quebec",
                    "Quebec"
                )
            },
            {
                "Nova Scotia",
                new LanguageBit(
                    "Nova Scotia",
                    "Nova Scotia"
                )
            },
            {
                "Newfoundland",
                new LanguageBit(
                    "Newfoundland",
                    "Newfoundland"
                )
            },
            {
                "Newfoundland and Labrador",
                new LanguageBit(
                    "Newfoundland",
                    "Newfoundland"
                )
            },
            {
                "Prince Edward Island",
                new LanguageBit(
                    "Prince Edward Island",
                    "Prince Edward Island"
                )
            },
            {
                "New Brunswick",
                new LanguageBit(
                    "New Brunswick",
                    "New Brunswick"
                )
            },
            {
                "Yukon",
                new LanguageBit(
                    "Yukon",
                    "Yukon"
                )
            },
            {
                "Northwest Territories",
                new LanguageBit(
                    "Northwest Territories",
                    "Northwest Territories"
                )
            },
            {
                "Nunavut",
                new LanguageBit(
                    "Nunavut",
                    "Nunavut"
                )
            },
            /*** Education Level ***/ 
            {
                "Apprenticeship",
                new LanguageBit(
                    "Apprenticeship",
                    "Apprenticeship"
                )
            },
            {
                "College",
                new LanguageBit(
                    "College",
                    "College"
                )
            },
            {
                "Other",
                new LanguageBit(
                    "Other",
                    "Other"
                )
            },
            {
                "Primary - Elementary",
                new LanguageBit(
                    "Primary - Elementary",
                    "Primary - Elementary"
                )
            },
            {
                "Secondary - High School",
                new LanguageBit(
                    "Secondary - High School",
                    "Secondary - High School"
                )
            },
            {
                "University",
                new LanguageBit(
                    "University",
                    "University"
                )
            },
            /*** Error ***/
            {
                "error_title",
                new LanguageBit(
                    "Error",
                    "Error"
                )
            },
            {
                "error_info",
                new LanguageBit(
                    "Sorry! An error occurred while running the simulation. Please try a new simulation with different values.",
                    "Sorry! An error occurred while running the simulation. Please try a new simulation with different values."
                )
            },
            {
                "error_message_title",
                new LanguageBit(
                    "Error Message",
                    "Error Message"
                )
            },
        };
    
        public string Get(string key) {
            if (Dict.ContainsKey(key)) {
                var langBit = Dict[key];
                if (_language == "fr") {
                    return langBit.French;
                } else {
                    return langBit.English;
                }
            }
            return key;
        }
    }
}