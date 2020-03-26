<?php

/* project/create.html.twig */
class __TwigTemplate_2a1b5d707aa72104692b6ffa1a05c4fb1e74d1bf350d67ef9d0e176233c33cfd extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", "project/create.html.twig", 1);
        $this->blocks = array(
            'main' => array($this, 'block_main'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "base.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_d7c3c3528bdf22c43816f852b98d803d7ce72dce678f3cd7d9b222498c7c73cb = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_d7c3c3528bdf22c43816f852b98d803d7ce72dce678f3cd7d9b222498c7c73cb->enter($__internal_d7c3c3528bdf22c43816f852b98d803d7ce72dce678f3cd7d9b222498c7c73cb_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "project/create.html.twig"));

        $__internal_9031d1e29bfd6d20baea437bf2388d888220adfc57343093b5583b811e53596c = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_9031d1e29bfd6d20baea437bf2388d888220adfc57343093b5583b811e53596c->enter($__internal_9031d1e29bfd6d20baea437bf2388d888220adfc57343093b5583b811e53596c_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "project/create.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_d7c3c3528bdf22c43816f852b98d803d7ce72dce678f3cd7d9b222498c7c73cb->leave($__internal_d7c3c3528bdf22c43816f852b98d803d7ce72dce678f3cd7d9b222498c7c73cb_prof);

        
        $__internal_9031d1e29bfd6d20baea437bf2388d888220adfc57343093b5583b811e53596c->leave($__internal_9031d1e29bfd6d20baea437bf2388d888220adfc57343093b5583b811e53596c_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_92c559cc795d80da3b40a7a3dd66f669be57e2d8bcce58a393f922f729df5dab = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_92c559cc795d80da3b40a7a3dd66f669be57e2d8bcce58a393f922f729df5dab->enter($__internal_92c559cc795d80da3b40a7a3dd66f669be57e2d8bcce58a393f922f729df5dab_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_80d5d4955270e755b4fbe6d4e59fc6ba75eeffaf8801b7fcc3c01c46a5dca9d5 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_80d5d4955270e755b4fbe6d4e59fc6ba75eeffaf8801b7fcc3c01c46a5dca9d5->enter($__internal_80d5d4955270e755b4fbe6d4e59fc6ba75eeffaf8801b7fcc3c01c46a5dca9d5_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "<div class=\"wrapper\">
    <form class=\"project-create\" method=\"post\">
        <div class=\"create-header\">
            Create Project
        </div>
        <div class=\"create-title\">
            <div class=\"create-title-label\">Title</div>
            <input class=\"create-title-content\" name=\"project[title]\" />
        </div>
        <div class=\"create-description\">
            <div class=\"create-description-label\">Description</div>
            <textarea rows=\"3\" class=\"create-description-content\" name=\"project[description]\"></textarea>
        </div>
        <div class=\"create-budget\">
            <div class=\"create-budget-label\">Budget</div>
            <input type=\"number\" min=\"0\" class=\"create-budget-content\" name=\"project[budget]\" />
        </div>
        <div class=\"create-button-holder\">
            <button type=\"submit\" class=\"submit-button\">Create Project</button>
            <a type=\"button\" href=\"/\" class=\"back-button\">Back</a>
        </div>

        ";
        // line 26
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Form\TwigRenderer')->searchAndRenderBlock($this->getAttribute(($context["form"] ?? $this->getContext($context, "form")), "_token", array()), 'row');
        echo "
    </form>
</div>
";
        
        $__internal_80d5d4955270e755b4fbe6d4e59fc6ba75eeffaf8801b7fcc3c01c46a5dca9d5->leave($__internal_80d5d4955270e755b4fbe6d4e59fc6ba75eeffaf8801b7fcc3c01c46a5dca9d5_prof);

        
        $__internal_92c559cc795d80da3b40a7a3dd66f669be57e2d8bcce58a393f922f729df5dab->leave($__internal_92c559cc795d80da3b40a7a3dd66f669be57e2d8bcce58a393f922f729df5dab_prof);

    }

    public function getTemplateName()
    {
        return "project/create.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  73 => 26,  49 => 4,  40 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends \"base.html.twig\" %}

{% block main %}
<div class=\"wrapper\">
    <form class=\"project-create\" method=\"post\">
        <div class=\"create-header\">
            Create Project
        </div>
        <div class=\"create-title\">
            <div class=\"create-title-label\">Title</div>
            <input class=\"create-title-content\" name=\"project[title]\" />
        </div>
        <div class=\"create-description\">
            <div class=\"create-description-label\">Description</div>
            <textarea rows=\"3\" class=\"create-description-content\" name=\"project[description]\"></textarea>
        </div>
        <div class=\"create-budget\">
            <div class=\"create-budget-label\">Budget</div>
            <input type=\"number\" min=\"0\" class=\"create-budget-content\" name=\"project[budget]\" />
        </div>
        <div class=\"create-button-holder\">
            <button type=\"submit\" class=\"submit-button\">Create Project</button>
            <a type=\"button\" href=\"/\" class=\"back-button\">Back</a>
        </div>

        {{ form_row(form._token) }}
    </form>
</div>
{% endblock %}", "project/create.html.twig", "C:\\Projects\\Software-Technologies\\Exam-3-Jan-2018\\Skeletons\\PHP-Skeleton\\app\\Resources\\views\\project\\create.html.twig");
    }
}
